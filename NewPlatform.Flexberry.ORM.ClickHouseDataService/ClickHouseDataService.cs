namespace NewPlatform.Flexberry.ORM
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.Text;

    using ClickHouse.Ado;

    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Business.Audit.HelpStructures;
    using STORMDO = ICSSoft.STORMNET;

    /// <summary>
    /// Flexberry ORM DataService for ClickHouse Storage.
    /// </summary>
    public class ClickHouseDataService : SQLDataService
    {
        /// <summary>
        /// Creates new instance of <see cref="ClickHouseDataService"/>.
        /// </summary>
        public ClickHouseDataService()
            : base()
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
        public override void UpdateObjects(ref DataObject[] objects, DataObjectCache DataObjectCache, bool AlwaysThrowException)
        {
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

            using (DbTransactionWrapper dbTransactionWrapper = new DbTransactionWrapper(this))
            {
                try
                {
                    UpdateObjectsByExtConn(ref objects, DataObjectCache, AlwaysThrowException, dbTransactionWrapper);
                }
                catch (Exception)
                {
                    throw;
                }
            }
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
                AuditAdditionalInfo auditAdditionalInfo = AuditService.WriteCommonAuditOperationWithAutoFields(dobject, this, true, transaction); // Если что, то исключение будет проброшено
                if (auditAdditionalInfo != null && auditAdditionalInfo.AuditRecordPrimaryKey != Guid.Empty)
                {
                    auditOperationInfoList.Add(auditAdditionalInfo);
                }
            }
        }

        /// <inheritdoc/>
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
