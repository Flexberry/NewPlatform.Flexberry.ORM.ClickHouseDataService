namespace NewPlatform.Flexberry.ORM
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    using ClickHouse.Ado;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Interfaces;
    using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
    using ICSSoft.STORMNET.KeyGen;
    using ICSSoft.STORMNET.Security;
    using STORMFunction = ICSSoft.STORMNET.FunctionalLanguage.Function;

    /// <summary>
    /// Flexberry ORM DataService for ClickHouse Storage.
    /// </summary>
    public class ClickHouseDataService : SQLDataService
    {
        /// <summary>
        /// Создание сервиса данных для ClickHouse с указанием настроек проверки полномочий.
        /// </summary>
        /// <param name="securityManager">Сенеджер полномочий.</param>
        /// <param name="auditService">Сервис аудита.</param>
        /// <param name="businessServerProvider">The provider for <see cref="BusinessServer"/> creation.</param>
        public ClickHouseDataService(ISecurityManager securityManager, IAuditService auditService, IBusinessServerProvider businessServerProvider)
            : base(securityManager, auditService, businessServerProvider)
        {
        }

        /// <summary>
        /// Перед выполнением обновления объектов в базе. После отработки бизнес-серверов.
        /// </summary>
        public event BeforeUpdateObjectsEventHandler BeforeUpdateObjects;

        /// <summary>
        /// После выполнения обновления объектов в базе.
        /// </summary>
        public event AfterUpdateObjectsEventHandler AfterUpdateObjects;

        /// <inheritdoc />
        protected override IDbTransaction CreateTransaction(IDbConnection connection)
        {
            return new FakeDbTransaction() { Connection = connection };
        }

        /// <inheritdoc />
        public override IDbConnection GetConnection()
        {
            var settings = new ClickHouseConnectionSettings(CustomizationString);

            var cnn = new ClickHouseConnection(settings);

            return cnn;
        }

        /// <inheritdoc />
        public override string GetConvertToTypeExpression(Type valType, string value)
        {
            if (valType == typeof(Guid))
            {
                return "Convert(uniqueidentifier," + value + ")";
            }
            else if (valType == typeof(decimal))
            {
                //return "Convert(decimal," + value + ")";
                return value;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <inheritdoc/>
        public override ICSSoft.STORMNET.DataObject[] LoadObjects(
            LoadingCustomizationStruct customizationStruct,
            ref object state, DataObjectCache dataObjectCache)
        {
            RunChangeCustomizationString(customizationStruct.LoadingTypes);
            using (EmptyDbTransactionWrapper dbTransactionWrapper = new EmptyDbTransactionWrapper(GetConnection()))
            {
                return LoadObjectsByExtConn(customizationStruct, ref state, dataObjectCache, dbTransactionWrapper);
            }
        }

        /// <inheritdoc/>
        public override void UpdateObjectsByExtConn(
            ref DataObject[] objects, DataObjectCache dataObjectCache, bool alwaysThrowException, IDbConnection connection, IDbTransaction transaction)
        {
            using EmptyDbTransactionWrapper dbTransactionWrapper = new EmptyDbTransactionWrapper(connection, transaction);
            UpdateObjectsByExtConn(ref objects, dataObjectCache, alwaysThrowException, dbTransactionWrapper);
        }

        /// <inheritdoc/>
        public override void LoadObject(
            ICSSoft.STORMNET.View dataObjectView,
            ICSSoft.STORMNET.DataObject dataObject, bool clearDataObject, bool checkExistingObject, DataObjectCache dataObjectCache)
        {
            if (dataObjectView == null)
            {
                throw new ArgumentNullException(nameof(dataObjectView), "Не указано представление для загрузки объекта. Обратитесь к разработчику.");
            }

            if (dataObject == null)
            {
                throw new ArgumentNullException(nameof(dataObject), "Не указан объект для загрузки. Обратитесь к разработчику.");
            }

            Type doType = dataObject.GetType();
            RunChangeCustomizationString(new Type[] { doType });

            using (EmptyDbTransactionWrapper dbTransactionWrapper = new EmptyDbTransactionWrapper(GetConnection()))
            {
                LoadObjectByExtConn(dataObjectView, dataObject, clearDataObject, checkExistingObject, dataObjectCache, dbTransactionWrapper.Connection, dbTransactionWrapper.Transaction);
            }
        }

        /// <inheritdoc/>
        public override object[][] ReadFirstByExtConn(string query, ref object state, int loadingBufferSize, IDbConnection connection, IDbTransaction transaction)
        {
            object taskid = BusinessTaskMonitor.BeginTask("Reading data" + Environment.NewLine + query);
            try
            {
                using (IDbCommand myCommand = connection.CreateCommand())
                {
                    myCommand.CommandText = query;
                    myCommand.Transaction = transaction;
                    CustomizeCommand(myCommand);
                    // Отличие во фрагменте ниже. ClickHouse.ADO не справлялся с закрытием коннекции через using из-за закрытия коннекции в ReadNextByExtConn.
                    IDataReader myReader = myCommand.ExecuteReader();
                    try
                    {
                        myReader.NextResult();
                        state = new object[] { connection, myReader };
                        return ReadNextByExtConn(ref state, loadingBufferSize);
                    }
                    finally
                    {
                        if (!myReader.IsClosed) // Может быть закрыто в ReadNextByExtConn.
                        {
                            myReader.Close();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new ExecutingQueryException(query, string.Empty, e);
            }
            finally
            {
                BusinessTaskMonitor.EndTask(taskid);
            }
        }

        /// <summary>
        /// Изменить строку соединения, согласно делегату <see cref="ChangeCustomizationString"/>.
        /// Копия private-метода из <see cref="SQLDataService"/>.
        /// </summary>
        /// <param name="types">Типы загружаемых объектов - по ним будет изменена строка соединения.</param>
        private void RunChangeCustomizationString(Type[] types)
        {
            if (!DoNotChangeCustomizationString && ChangeCustomizationString != null)
            {
                string cs = ChangeCustomizationString(types);
                CustomizationString = string.IsNullOrEmpty(cs) ? CustomizationString : cs;
            }
        }

        /// <summary>
        /// Изменить строку соединения, согласно делегату <see cref="ChangeCustomizationString"/>.
        /// Копия private-метода из <see cref="SQLDataService"/>.
        /// </summary>
        /// <param name="dataObjects">Загружаемые объекты - по списку их типов будет изменена строка соединения.</param>
        private void RunChangeCustomizationString(DataObject[] dataObjects)
        {
            if (!DoNotChangeCustomizationString && ChangeCustomizationString != null)
            {
                var types = dataObjects.Select(x => x.GetType()).Distinct().ToArray();
                string cs = ChangeCustomizationString(types);
                CustomizationString = string.IsNullOrEmpty(cs) ? CustomizationString : cs;
            }
        }

        /// <summary>
        /// Загрузка объектов с использованием обёртки с коннекцией и транзакцией.
        /// Копия private-метода из <see cref="SQLDataService"/>.
        /// </summary>
        /// <param name="customizationStruct">Структура, определяющая, что и как грузить.</param>
        /// <param name="state">Состояние вычитки (для последующей дочитки).</param>
        /// <param name="dataObjectCache">Кэш объектов для вычитки.</param>
        /// <param name="dbTransactionWrapper">Обёртка с коннекцией и тразакцией.</param>
        /// <returns>Загруженные данные.</returns>
        private DataObject[] LoadObjectsByExtConn(
            LoadingCustomizationStruct customizationStruct,
            ref object state,
            DataObjectCache dataObjectCache,
            DbTransactionWrapper dbTransactionWrapper)
        {
            dataObjectCache.StartCaching(false);
            try
            {
                // Применим полномочия на строки.
                ApplyReadPermissions(customizationStruct, SecurityManager);

                Type[] dataObjectType = customizationStruct.LoadingTypes;
                StorageStructForView[] storageStruct;

                string selectString = string.Empty;
                selectString = GenerateSQLSelect(customizationStruct, false, out storageStruct, false);
                // Получаем данные.
                object[][] resValue = ReadFirstByExtConn(
                                            selectString, ref state, customizationStruct.LoadingBufferSize, dbTransactionWrapper.Connection, dbTransactionWrapper.Transaction);
                state = new object[] { state, dataObjectType, storageStruct, customizationStruct, CustomizationString };
                DataObject[] res = null;

                if (resValue == null)
                {
                    res = new DataObject[0];
                }
                else
                {
                    res = Utils.ProcessingRowsetData(
                            resValue, dataObjectType, storageStruct, customizationStruct, this, Types, dataObjectCache, SecurityManager, dbTransactionWrapper.Connection, dbTransactionWrapper.Transaction);
                }

                return res;
            }
            finally
            {
                dataObjectCache.StopCaching();
            }
        }

        /// <summary>
        /// Применение полномочий на чтение строк.
        /// Копия private-метода из <see cref="SQLDataService"/>.
        /// </summary>
        /// <param name="customizationStruct">Настройка выборки, которая будет изменена.</param>
        /// <param name="securityManager">Менеджер полномочий.</param>
        private static void ApplyReadPermissions(LoadingCustomizationStruct customizationStruct, ISecurityManager securityManager)
        {
            object limitObject;
            bool canAccess;
            var operationResult = securityManager.GetLimitForAccess(
                customizationStruct.View.DefineClassType, tTypeAccess.Read, out limitObject, out canAccess);
            STORMFunction limit = limitObject as STORMFunction;
            if (operationResult == OperationResult.Успешно)
            {
                if (limit != null)
                {
                    // Применим его к lcs через И.
                    if (customizationStruct.LimitFunction == null)
                    {
                        customizationStruct.LimitFunction = limit;
                    }
                    else
                    {
                        SQLWhereLanguageDef ldef = SQLWhereLanguageDef.LanguageDef;
                        customizationStruct.LimitFunction = ldef.GetFunction(
                            ldef.funcAND, customizationStruct.LimitFunction, limit);
                    }

                    // Убеждаемся, что все свойства из ограничения есть в представлении. Удалим добавленное из ограничения "STORMMainObjectKey".
                    var properties = new List<string>(customizationStruct.LimitFunction.GetLimitProperties().Where(x => x != SQLWhereLanguageDef.StormMainObjectKey));
                    customizationStruct.View.AddProperties(properties.ToArray());
                }
            }
            else
            {
                // TODO: тут надо подумать что будем делать. Наверное надо вызывать исключение и не давать ничего. Пока просто запишем в лог и не будем показывать ошибку.
                LogService.LogError(string.Format("SecurityManager.GetLimitForAccess: {0}", operationResult));
            }
        }

        /// <summary>
        /// Конвертация константных значений в строки запроса.
        /// </summary>
        /// <param name="value">Значение, которое требуется преобразовать в соответствующую в БД строку.</param>
        /// <returns>Полученная строка.</returns>
        public override string ConvertSimpleValueToQueryValueString(object value)
        {
            if (value == null)
            {
                return "NULL";
            }

            Type valType = value.GetType();
            if (valType == typeof(string))
            {
                if ((string)value == string.Empty)
                {
                    return "NULL";
                }

                return "'" + value.ToString().Replace("'", "''") + "'";
            }

            if (value is char)
            {
                return Convert.ToInt32((char)value).ToString(CultureInfo.InvariantCulture);
            }

            if (valType == typeof(DateTime))
            {
                return "'" + ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss") + "'";
            }

            if (valType == typeof(TimeSpan))
            {
                return "'" + value.ToString() + "'";
            }

            if (valType == typeof(ICSSoft.STORMNET.KeyGen.KeyGuid))
            {
                return string.Format("'{0}'", value);
            }

            if (valType.IsEnum)
            {
                string s = EnumCaption.GetCaptionFor(value);
                if (s == null || s == string.Empty)
                {
                    return "NULL";
                }
                else
                {
                    return "'" + s + "'";
                }
            }

            if (valType == typeof(bool))
            {
                if ((bool)value)
                {
                    return "1";
                }

                return "0";
            }

            if (valType == typeof(Guid))
            {
                return "'" + ((Guid)value).ToString() + "'";
            }

            if (valType == typeof(double))
            {
                return ((double)value).ToString(System.Globalization.NumberFormatInfo.InvariantInfo);
            }

            if (valType == typeof(decimal))
            {
                return ((decimal)value).ToString(System.Globalization.NumberFormatInfo.InvariantInfo);
            }

            if (valType == typeof(float))
            {
                return ((float)value).ToString(System.Globalization.NumberFormatInfo.InvariantInfo);
            }

            if (valType.IsSubclassOf(typeof(DataObject)))
            {
                return ConvertSimpleValueToQueryValueString(((DataObject)value).__PrimaryKey);
            }

            if (valType == typeof(byte[]))
            {
                var sb = new StringBuilder(BitConverter.ToString((byte[])value));
                sb.Insert(0, "0x").Replace("-", string.Empty);
                return sb.ToString();
            }

            return value.ToString();
        }

        /// <summary>
        /// Вычитка первой партии данных.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="state"></param>
        /// <param name="loadingBufferSize"></param>
        /// <returns></returns>
        public override object[][] ReadFirst(string query, ref object state, int loadingBufferSize)
        {
            object task = BusinessTaskMonitor.BeginTask("Reading data" + Environment.NewLine + query);

            IDbConnection connection = null;
            IDataReader reader = null;
            try
            {
                connection = GetConnection();
                connection.Open();

                IDbCommand command = connection.CreateCommand();
                command.CommandText = query;
                CustomizeCommand(command);

                reader = command.ExecuteReader();
                reader.NextResult();
                state = new object[] { connection, reader };
                return ReadNext(ref state, loadingBufferSize);
            }
            catch (Exception e)
            {
                reader?.Close();
                connection?.Close();

                throw new ExecutingQueryException(query, string.Empty, e);
            }
            finally
            {
                BusinessTaskMonitor.EndTask(task);
            }
        }

        /// <summary>
        /// Вычитка следующей порции данных.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="loadingBufferSize"></param>
        /// <returns></returns>
        public override object[][] ReadNext(ref object state, int loadingBufferSize)
        {
            if (state == null || !state.GetType().IsArray)
            {
                return null;
            }

            IDataReader reader = (IDataReader)((object[])state)[1];

            object[][] result = null;
            var arl = new ArrayList();
            int i = 1;
            int fieldCount = reader.FieldCount;
            while (reader.RecordsAffected > 0 && (i <= loadingBufferSize || loadingBufferSize == 0))
            {
                while (reader.Read())
                {
                    object[] tmp = new object[fieldCount];
                    reader.GetValues(tmp);
                    arl.Add(tmp);
                    i++;
                }

                reader.NextResult();
            }

            if (arl.Count > 0)
            {
                result = (object[][])arl.ToArray(typeof(object[]));
            }

            if (i <= loadingBufferSize || loadingBufferSize == 0)
            {
                reader.Close();
                IDbConnection connection = (IDbConnection)((object[])state)[0];
                connection.Close();
                state = null;
            }

            return result;
        }

        /// <inheritdoc/>
        public override void UpdateObjects(ref DataObject[] objects, DataObjectCache dataObjectCache, bool alwaysThrowException)
        {
            RunChangeCustomizationString(objects);

            using (EmptyDbTransactionWrapper dbTransactionWrapper = new EmptyDbTransactionWrapper(GetConnection()))
            {
                try
                {
                    UpdateObjectsByExtConn(ref objects, dataObjectCache, alwaysThrowException, dbTransactionWrapper);
                    dbTransactionWrapper.CommitTransaction();
                }
                catch (Exception ex)
                {
                    dbTransactionWrapper.RollbackTransaction();
                    throw;
                }
            }
        }

        /// <inheritdoc />
        public override DbProviderFactory ProviderFactory => null;

        /// <inheritdoc/>
        protected override void CustomizeCommand(IDbCommand cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            string sql = cmd.CommandText;
            const string insertIntoConst = "insert into \"";

            if (sql.StartsWith(insertIntoConst, StringComparison.InvariantCultureIgnoreCase))
            {
                int insertIntoConstLength = insertIntoConst.Length;
                int tableNameEndIndex = sql.IndexOf("\"", insertIntoConstLength, StringComparison.InvariantCultureIgnoreCase);
                string tableName = sql.Substring(insertIntoConst.Length, tableNameEndIndex - insertIntoConstLength);
                cmd.CommandText = sql.Substring(0, insertIntoConstLength) + tableName + "Buffer" + sql.Substring(tableNameEndIndex);
            }

            base.CustomizeCommand(cmd);
        }

        /// <inheritdoc cref="SQLDataService"/>
        public override void GenerateSQLRowNumber(LoadingCustomizationStruct customizationStruct, ref string resQuery, string orderByExpr)
        {
            string nl = Environment.NewLine;
            if (customizationStruct.RowNumber != null)
            {
                long offset = long.MaxValue;
                long limit = 0;
                if (customizationStruct.RowNumber.StartRow == 0)
                {
                    customizationStruct.RowNumber.StartRow = 1;
                }

                if (customizationStruct.RowNumber.StartRow > 0)
                {
                    offset = customizationStruct.RowNumber.StartRow - 1;
                    if (customizationStruct.RowNumber.EndRow >= customizationStruct.RowNumber.StartRow)
                    {
                        limit = customizationStruct.RowNumber.EndRow - customizationStruct.RowNumber.StartRow + 1;
                    }
                }

                // FYI: https://clickhouse.tech/docs/en/sql-reference/statements/select/limit/
                resQuery = $"{resQuery}{nl}LIMIT {offset}, {limit}";
            }
        }

        /// <summary>
        /// Переопределенный метод записи объектов в БД. Все записи отправляются в бд в одном инсерте.
        /// </summary>
        /// <param name="objects">Объекты для обновления.</param>
        /// <param name="dataObjectCache">Кеш объектов.</param>
        /// <param name="alwaysThrowException">Если произошла ошибка в базе данных, не пытаться выполнять других запросов, сразу взводить ошибку.</param>
        /// <param name="dbTransactionWrapper">Экземпляр <see cref="DbTransactionWrapper" />.</param>
        public override void UpdateObjectsByExtConn(ref DataObject[] objects, DataObjectCache dataObjectCache, bool alwaysThrowException, DbTransactionWrapper dbTransactionWrapper)
        {
            var processingObjects = new ArrayList();

            string nl = Environment.NewLine;
            string nlk = ",";

            var processingObjectsKeys = new Dictionary<TypeKeyPair, bool>(new TypeKeyPairEqualityComparer());
            foreach (DataObject dobj in objects)
            {
                if (!ContainsKeyINProcessing(processingObjectsKeys, dobj))
                {
                    if (dobj.GetStatus(false) == ObjectStatus.Created)
                    {
                        KeyGenerator.GenerateUnique(dobj, this);
                    }

                    processingObjects.Add(dobj);
                    AddToProcessingObjectsKeys(processingObjectsKeys, dobj);
                }
            }

            Dictionary<string, List<object[]>> insertsWithBulk = new Dictionary<string, List<object[]>>();

            for (int i = 0; i < processingObjects.Count; i++)
            {
                var processingObject = (DataObject)processingObjects[i];

                ObjectStatus curObjectStatus = processingObject.GetStatus();
                Type typeOfProcessingObject = processingObject.GetType();
                BusinessServer[] bss = BusinessServerProvider.GetBusinessServer(typeOfProcessingObject, curObjectStatus, this);
                if (bss != null && bss.Length > 0)
                {
                    foreach (BusinessServer bs in bss)
                    {
                        ProcessBusinessServer(processingObject, typeOfProcessingObject, bs, processingObjects, processingObjectsKeys, ref curObjectStatus);
                    }
                }

                if (AuditService.IsTypeAuditable(typeOfProcessingObject))
                {
                    AuditService.AddCreateAuditInformation(processingObject);
                }

                string[] cols = Information.GetPropertyNamesForInsert(typeOfProcessingObject);
                object[] values = cols.Select(c =>
                {
                    object value = Information.GetPropValueByName(processingObject, c);

                    if (value == null)
                    {
                        return null;
                    }

                    // Подготовим значение для bulk-вставки через параметры.
                    Type valueType = value.GetType();

                    if (valueType.IsEnum)
                    {
                        string s = EnumCaption.GetCaptionFor(value);
                        value = string.IsNullOrEmpty(s) ? "NULL" : s;
                    }
                    else if (valueType == typeof(KeyGuid))
                    {
                        value = (value as KeyGuid).Guid;
                    }
                    else if (valueType.IsSubclassOf(typeof(DataObject)))
                    {
                        value = new Guid(((DataObject)value).__PrimaryKey.ToString());
                    }
                    else if (valueType == typeof(bool))
                    {
                        value = (byte)((bool)value ? 1 : 0);
                    }

                    return value;
                }).ToArray();

                string primaryKeyName = Information.GetPrimaryKeyStorageName(typeOfProcessingObject);
                IEnumerable<string> columns = cols.Select(x => x.Replace("__PrimaryKey", primaryKeyName));

                string mainTableName = Information.GetClassStorageName(typeOfProcessingObject);
                string query = $"INSERT INTO {PutIdentifierIntoBrackets(mainTableName)}{nl} ( {nl}{string.Join(nlk, columns)}{nl} ) {nl} VALUES @bulk;";

                if (insertsWithBulk.ContainsKey(query))
                {
                    insertsWithBulk[query].Add(values);
                }
                else
                {
                    List<object[]> newValuesList = new List<object[]> { values };
                    insertsWithBulk.Add(query, newValuesList);
                }
            }

            ExecuteBulkInsert(insertsWithBulk, alwaysThrowException, dbTransactionWrapper);
        }

        /// <summary>
        /// Формирует и выполняет команду вставки записей в одном инсерте.
        /// </summary>
        /// <param name="insertsWithBulk">Объекты для вставки.</param>
        /// <param name="alwaysThrowException">Если произошла ошибка в базе данных, не пытаться выполнять других запросов, сразу взводить ошибку.</param>
        /// <param name="dbTransactionWrapper">Экземпляр <see cref="DbTransactionWrapper" />.</param>
        private void ExecuteBulkInsert(Dictionary<string, List<object[]>> insertsWithBulk, bool alwaysThrowException, DbTransactionWrapper dbTransactionWrapper)
        {
            foreach (KeyValuePair<string, List<object[]>> insertBulk in insertsWithBulk)
            {
                IDbCommand command = dbTransactionWrapper.CreateCommand();
                string commandText = insertBulk.Key;
                command.CommandText = commandText;
                command.Parameters.Clear();
                command.Parameters.Add(
                    new ClickHouseParameter
                    {
                        DbType = DbType.Object,
                        ParameterName = "bulk",
                        Value = insertBulk.Value.ToArray(),
                    }
                );

                CustomizeCommand(command);
                Exception ex = null;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    ex = new ExecutingQueryException(commandText, string.Empty, exc);
                    if (alwaysThrowException)
                    {
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// Проверка на наличие объекта в коллекции обрабатываемых объектов.
        /// </summary>
        /// <param name="processedDictionary">
        /// Словарь обрабатываемых объектов.
        /// </param>
        /// <param name="dob">
        /// Объект данных.
        /// </param>
        /// <returns>
        /// Если объект содержится в коллекции, то <c>true</c>.
        /// </returns>
        private bool ContainsKeyINProcessing(Dictionary<TypeKeyPair, bool> processedDictionary, DataObject dob)
        {
            TypeKeyPair typeKeyPair = new TypeKeyPair(dob.GetType(), dob.__PrimaryKey);
            return processedDictionary.ContainsKey(typeKeyPair);
        }

        /// <summary>
        /// Добавление в словаре обрабатываемых объектов.
        /// </summary>
        /// <param name="processedDictionary">Словарь обрабатываемых объектов.</param>
        /// <param name="dob">Объект данных.</param>
        private void AddToProcessingObjectsKeys(Dictionary<TypeKeyPair, bool> processedDictionary, DataObject dob)
        {
            TypeKeyPair typeKeyPair = new TypeKeyPair(dob.GetType(), dob.__PrimaryKey);
            processedDictionary.Add(typeKeyPair, true);
        }

        /// <summary>
        /// Обработка объекта бизнес-сервером.
        /// </summary>
        /// <param name="processingObject">Обрабатываемый объект.</param>
        /// <param name="typeOfProcessingObject">Тип обрабатываемого объекта.</param>
        /// <param name="bs">Экземпляр бизнес-сервера.</param>
        /// <param name="processingObjects">Массив обрабатываемых объектов.</param>
        /// <param name="processingObjectsKeys">Словарь ключей обрабатываемых объектов.</param>
        /// <param name="curObjectStatus">Статус объекта.</param>
        private void ProcessBusinessServer(DataObject processingObject, Type typeOfProcessingObject, BusinessServer bs, ArrayList processingObjects, Dictionary<TypeKeyPair, bool> processingObjectsKeys, ref ObjectStatus curObjectStatus)
        {
            try
            {
                bs.ObjectsToUpdate = processingObjects;
                object prevPrimaryKey = processingObject.__PrimaryKey;
                DataObject[] subobjects = bs.OnUpdateDataobject(processingObject);
                curObjectStatus = processingObject.GetStatus(true);
                if (!processingObject.__PrimaryKey.Equals(prevPrimaryKey))
                {
                    TypeKeyPair typeKeyPair = new TypeKeyPair(typeOfProcessingObject, prevPrimaryKey);
                    processingObjectsKeys.Remove(typeKeyPair);
                    if (curObjectStatus == ObjectStatus.Created)
                    {
                        KeyGenerator.GenerateUnique(processingObject, this);
                    }

                    AddToProcessingObjectsKeys(processingObjectsKeys, processingObject);
                }

                foreach (DataObject subobject in subobjects)
                {
                    var subobjectStatus = subobject.GetStatus(true);
                    if (!ContainsKeyINProcessing(processingObjectsKeys, subobject))
                    {
                        if (subobjectStatus == ObjectStatus.Created)
                        {
                            KeyGenerator.GenerateUnique(subobject, this);
                        }

                        processingObjects.Add(subobject);
                        AddToProcessingObjectsKeys(processingObjectsKeys, subobject);
                    }
                }
            }
            finally
            {
                // Высвобождаем обрабатываемые объекты.
                bs.ObjectsToUpdate = null;
            }
        }

        public override DbConnection GetDbConnection()
        {
            throw new NotImplementedException();
        }
    }
}
