namespace NewPlatform.Flexberry.ORM
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Data;
    using System.Globalization;
    using System.Text;

    using ClickHouse.Ado;

    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Business.Audit.HelpStructures;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    using ICSSoft.STORMNET.Security;
    using STORMDO = ICSSoft.STORMNET;

    /// <summary>
    /// Flexberry ORM DataService for ClickHouse Storage.
    /// </summary>
    public class ClickHouseDataService : SQLDataService
    {
        /// <summary>
        /// Creates new instance of <see cref="ClickHouseDataService"/>.
        /// </summary>
        public ClickHouseDataService():base()
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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

                string returnedString = "'" + value.ToString().Replace("'", "''") + "'";
                returnedString = returnedString.Replace("\\", "/");
                returnedString = returnedString.Replace("\"", string.Empty);

                return returnedString;
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
                string s = STORMDO.EnumCaption.GetCaptionFor(value);
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
                if (reader != null)
                {
                    reader.Close();
                }

                if (connection != null)
                {
                    connection.Close();
                }

                throw new ExecutingQueryException(query, string.Empty, e);
            }
            finally
            {
                BusinessTaskMonitor.EndTask(task);
            }
        }

        /// <summary>
        /// Вычитка следующей порции данных
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

        /// <summary>
        /// Обновить хранилище по объектам (есть параметр, указывающий, всегда ли необходимо взводить ошибку
        /// и откатывать транзакцию при неудачном запросе в базу данных). Если
        /// он true, всегда взводится ошибка. Иначе, выполнение продолжается.
        /// Однако, при этом есть опасность преждевременного окончания транзакции, с переходом для остальных
        /// запросов режима транзакционности в autocommit. Проявлением проблемы являются ошибки навроде:
        /// The COMMIT TRANSACTION request has no corresponding BEGIN TRANSACTION
        /// </summary>
        /// <param name="objects">Объекты для обновления.</param>
        /// <param name="DataObjectCache">Кэш объектов данных.</param>
        /// <param name="AlwaysThrowException">Если произошла ошибка в базе данных, не пытаться выполнять других запросов, сразу взводить ошибку и откатывать транзакцию.</param>
        public override void UpdateObjects(ref DataObject[] objects, DataObjectCache DataObjectCache, bool AlwaysThrowException)
        {
            object id = BusinessTaskMonitor.BeginTask("Update objects");
            if (!DoNotChangeCustomizationString && ChangeCustomizationString != null)
            {
                var tps = new List<Type>();
                foreach (DataObject d in objects)
                {
                    Type t = d.GetType();
                    if (!tps.Contains(t))
                    {
                        tps.Add(t);
                    }
                }

                string cs = ChangeCustomizationString(tps.ToArray());
                CustomizationString = string.IsNullOrEmpty(cs) ? CustomizationString : cs;
            }

            // Перенесли этот метод повыше, потому что строка соединения может быть сменена в бизнес-сервере делегатом смены строки соединения (если что-нибудь почитают).
            IDbConnection conection = GetConnection();

            var DeleteQueries = new StringCollection();
            var UpdateQueries = new StringCollection();
            var UpdateFirstQueries = new StringCollection();
            var InsertQueries = new StringCollection();

            var DeleteTables = new StringCollection();
            var UpdateTables = new StringCollection();
            var InsertTables = new StringCollection();
            var TableOperations = new SortedList();
            var QueryOrder = new StringCollection();

            var AllQueriedObjects = new ArrayList();

            var auditOperationInfoList = new List<AuditAdditionalInfo>();
            var extraProcessingList = new List<DataObject>();
            GenerateQueriesForUpdateObjects(DeleteQueries, DeleteTables, UpdateQueries, UpdateFirstQueries, UpdateTables, InsertQueries, InsertTables, TableOperations, QueryOrder, true, AllQueriedObjects, DataObjectCache, extraProcessingList, objects);

            GenerateAuditForAggregators(AllQueriedObjects, DataObjectCache, ref extraProcessingList);

            OnBeforeUpdateObjects(AllQueriedObjects);

            // Сортируем объекты в порядке заданным графом связности.
            extraProcessingList.Sort((x, y) =>
            {
                int indexX = QueryOrder.IndexOf(Information.GetClassStorageName(x.GetType()));
                int indexY = QueryOrder.IndexOf(Information.GetClassStorageName(y.GetType()));
                return indexX.CompareTo(indexY);
            });

            Exception ex = null;

            /*access checks*/

            foreach (DataObject dtob in AllQueriedObjects)
            {
                Type dobjType = dtob.GetType();
                if (!SecurityManager.AccessObjectCheck(dobjType, tTypeAccess.Full, false))
                {
                    switch (dtob.GetStatus(false))
                    {
                        case ObjectStatus.Created:
                            SecurityManager.AccessObjectCheck(dobjType, tTypeAccess.Insert, true);
                            break;
                        case ObjectStatus.Altered:
                            SecurityManager.AccessObjectCheck(dobjType, tTypeAccess.Update, true);
                            break;
                        case ObjectStatus.Deleted:
                            SecurityManager.AccessObjectCheck(dobjType, tTypeAccess.Delete, true);
                            break;
                    }
                }
            }

            /*access checks*/

            if (DeleteQueries.Count > 0 || UpdateQueries.Count > 0 || InsertQueries.Count > 0)
            { // Порядок выполнения запросов: delete,insert,update
                if (AuditService.IsAuditEnabled)
                {
                    /* Аудит проводится именно здесь, поскольку на этот момент все бизнес-сервера на объектах уже выполнились,
                     * объекты находятся именно в том состоянии, в каком должны были пойти в базу + в будущем можно транзакцию передать на исполнение
                     */
                    AuditOperation(extraProcessingList, auditOperationInfoList); // TODO: подумать, как записывать аудит до OnBeforeUpdateObjects, но уже потенциально с транзакцией
                }

                conection.Open();

                string query = string.Empty;
                string prevQueries = string.Empty;
                object subTask = null;
                try
                {
                    IDbCommand command = conection.CreateCommand();

                    #region прошли вглубь обрабатывая only Update||Insert
                    bool go = true;
                    do
                    {
                        string table = QueryOrder[0];
                        if (!TableOperations.ContainsKey(table))
                        {
                            TableOperations.Add(table, OperationType.None);
                        }

                        var ops = (OperationType)TableOperations[table];

                        if ((ops & OperationType.Delete) != OperationType.Delete)
                        {
                            // Смотрим есть ли Инсерты.
                            if ((ops & OperationType.Insert) == OperationType.Insert)
                            {
                                if (
                                    (ex =
                                     RunCommands(InsertQueries, InsertTables, table, command, id, AlwaysThrowException))
                                    == null)
                                {
                                    ops = Minus(ops, OperationType.Insert);
                                    TableOperations[table] = ops;
                                }
                                else
                                {
                                    go = false;
                                }
                            }

                            // Смотрим есть ли Update.
                            if (go && ((ops & OperationType.Update) == OperationType.Update))
                            {
                                if ((ex = RunCommands(UpdateQueries, UpdateTables, table, command, id, AlwaysThrowException)) == null)
                                {
                                    ops = Minus(ops, OperationType.Update);
                                    TableOperations[table] = ops;
                                }
                                else
                                {
                                    go = false;
                                }
                            }

                            if (go)
                            {
                                QueryOrder.RemoveAt(0);
                                go = QueryOrder.Count > 0;
                            }
                        }
                        else
                        {
                            go = false;
                        }
                    }
                    while (go);

                    #endregion
                    if (QueryOrder.Count > 0)
                    {
                        #region сзади чистые Update

                        go = true;
                        int queryOrderIndex = QueryOrder.Count - 1;
                        do
                        {
                            string table = QueryOrder[queryOrderIndex];
                            if (TableOperations.ContainsKey(table))
                            {
                                var ops = (OperationType)TableOperations[table];

                                if (ops == OperationType.Update)
                                {
                                    if (
                                        (ex = RunCommands(UpdateQueries, UpdateTables, table, command, id, AlwaysThrowException)) == null)
                                    {
                                        ops = Minus(ops, OperationType.Update);
                                        TableOperations[table] = ops;
                                    }
                                    else
                                    {
                                        go = false;
                                    }

                                    if (go)
                                    {
                                        queryOrderIndex--;
                                        go = queryOrderIndex >= 0;
                                    }
                                }
                                else
                                {
                                    go = false;
                                }
                            }
                            else
                            {
                                queryOrderIndex--;
                            }
                        }
                        while (go);

                        #endregion
                    }

                    foreach (string table in QueryOrder)
                    {
                        if ((ex = RunCommands(UpdateFirstQueries, UpdateTables, table, command, id, AlwaysThrowException)) != null)
                        {
                            throw ex;
                        }
                    }

                    // Удаляем в обратном порядке.
                    for (int i = QueryOrder.Count - 1; i >= 0; i--)
                    {
                        string table = QueryOrder[i];
                        if ((ex = RunCommands(DeleteQueries, DeleteTables, table, command, id, AlwaysThrowException)) != null)
                        {
                            throw ex;
                        }
                    }

                    // А теперь опять с начала.
                    foreach (string table in QueryOrder)
                    {
                        if ((ex = RunCommands(InsertQueries, InsertTables, table, command, id, AlwaysThrowException)) != null)
                        {
                            throw ex;
                        }

                        if ((ex = RunCommands(UpdateQueries, UpdateTables, table, command, id, AlwaysThrowException)) != null)
                        {
                            throw ex;
                        }
                    }

                    if (AuditService.IsAuditEnabled && auditOperationInfoList.Count > 0)
                    { // Нужно зафиксировать операции аудита (то есть сообщить, что всё было корректно выполнено и запомнить время)
                        AuditService.RatifyAuditOperationWithAutoFields(
                            tExecutionVariant.Executed,
                            AuditAdditionalInfo.SetNewFieldValuesForList(null, this, auditOperationInfoList),
                            this,
                            true);
                    }
                }
                catch (Exception excpt)
                {
                    if (AuditService.IsAuditEnabled && auditOperationInfoList.Count > 0)
                    { // Нужно зафиксировать операции аудита (то есть сообщить, что всё было откачено)
                        AuditService.RatifyAuditOperationWithAutoFields(tExecutionVariant.Failed, auditOperationInfoList, this, false);
                    }

                    conection.Close();
                    BusinessTaskMonitor.EndSubTask(subTask);
                    throw new ExecutingQueryException(query, prevQueries, excpt);
                }

                conection.Close();

                var res = new ArrayList();
                foreach (DataObject changedObject in objects)
                {
                    changedObject.ClearPrototyping(true);

                    if (changedObject.GetStatus(false) != STORMDO.ObjectStatus.Deleted)
                    {
                        Utils.UpdateInternalDataInObjects(changedObject, true, DataObjectCache);
                        res.Add(changedObject);
                    }
                }

                foreach (DataObject dobj in AllQueriedObjects)
                {
                    if (dobj.GetStatus(false) != STORMDO.ObjectStatus.Deleted
                        && dobj.GetStatus(false) != STORMDO.ObjectStatus.UnAltered)
                    {
                        Utils.UpdateInternalDataInObjects(dobj, true, DataObjectCache);
                    }
                }

                objects = new DataObject[res.Count];
                res.CopyTo(objects);
                BusinessTaskMonitor.EndTask(id);
            }

            AfterUpdateObjects?.Invoke(this, new DataObjectsEventArgs(objects));
        }

        private void OnBeforeUpdateObjects(ArrayList allQueriedObjects)
        {
            if (BeforeUpdateObjects == null)
            {
                return;
            }

            var changedObjects = new List<DataObject>(allQueriedObjects.Count);

            foreach (var obj in allQueriedObjects)
            {
                changedObjects.Add(obj as DataObject);
            }

            BeforeUpdateObjects(this, new DataObjectsEventArgs(changedObjects.ToArray()));
        }

        /// <summary>
        /// Провести аудит операции для одного объекта.
        /// </summary>
        /// <param name="dobject"> Объект, аудит которого нужно провести. </param>
        /// <param name="auditOperationInfoList"> Список id записей аудита. </param>
        /// <param name="transaction">
        /// Транзакция, через которую необходимо проводить выполнение зачиток из БД приложения аудиту
        /// (при работе AuditService иногда необходимо дочитать объект или получить сохранённую копию,
        /// а выполнение данного действия без транзакции может привести к взаимоблокировке).
        /// </param>
        private void AuditOperation(DataObject dobject, ICollection<AuditAdditionalInfo> auditOperationInfoList, IDbTransaction transaction)
        {
            if (dobject != null && AuditService.IsAuditEnabled)
            {
                AuditAdditionalInfo auditAdditionalInfo =
                            AuditService.WriteCommonAuditOperationWithAutoFields(dobject, this, true, transaction); // Если что, то исключение будет проброшено
                if (auditAdditionalInfo != null && auditAdditionalInfo.AuditRecordPrimaryKey != Guid.Empty)
                {
                    auditOperationInfoList.Add(auditAdditionalInfo);
                }
            }
        }

        /// <summary>
        /// Провести аудит операции для нескольких объектов.
        /// </summary>
        /// <param name="dobjects"> Объект, аудит которого нужно провести. </param>
        /// <param name="auditOperationInfoList"> Список id записей аудита. </param>
        /// <param name="transaction">
        /// Транзакция, через которую необходимо проводить выполнение зачиток из БД приложения аудиту
        /// (при работе AuditService иногда необходимо дочитать объект или получить сохранённую копию,
        /// а выполнение данного действия без транзакции может привести к взаимоблокировке).
        /// По умолчанию - null.
        /// </param>
        private void AuditOperation(IEnumerable<DataObject> dobjects, ICollection<AuditAdditionalInfo> auditOperationInfoList, IDbTransaction transaction = null)
        {
            if (dobjects != null)
            {
                foreach (var dobject in dobjects)
                {
                    AuditOperation(dobject, auditOperationInfoList, transaction);
                }
            }
        }

        public override void GenerateSQLRowNumber(LoadingCustomizationStruct customizationStruct, ref string resQuery, string orderByExpr)
        {
            string nl = Environment.NewLine;
            if (customizationStruct.RowNumber != null)
            {
                int fromInd = resQuery.IndexOf("FROM (");
                string селектСамогоВерхнегоУр = resQuery.Substring(0, fromInd);

                if (!string.IsNullOrEmpty(orderByExpr))
                {
                    resQuery = resQuery.Replace(orderByExpr, string.Empty);
                }
                    resQuery = resQuery.Insert(fromInd, "," + nl + "rowNumberInAllBlocks() as \"RowNumber\"" + nl);

                int startRow = customizationStruct.RowNumber.StartRow - 1;
                int endRow = customizationStruct.RowNumber.EndRow - 1;
                resQuery = селектСамогоВерхнегоУр + nl + "FROM (" + nl + resQuery + ") rn" + nl + "where \"RowNumber\" between " + startRow.ToString() + " and " + endRow.ToString() + nl +
                    orderByExpr;
            }
        }
    }
}
