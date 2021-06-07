[assembly: Xunit.CollectionBehavior(MaxParallelThreads = 1, DisableTestParallelization = true)]

namespace NewPlatform.ClickHouseDataService.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using ClickHouse.Ado;
    using ICSSoft.STORMNET.Business;
    using Xunit;

    using ClickHouseDataService = NewPlatform.Flexberry.ORM.ClickHouseDataService;

    public abstract class BaseIntegratedTest : IDisposable
    {
        private static string connectionStringClickHouse;

        private const string poolingFalseConst = "Pooling=false;";

        /// <summary>
        /// The temporary database name prefix.
        /// </summary>
        private readonly string _tempDbNamePrefix;

        private string _databaseName;

        /// <summary>
        /// The data services for temp databases (for <see cref="DataServices"/>).
        /// </summary>
        private readonly List<IDataService> _dataServices = new List<IDataService>();

        /// <summary>
        /// Flag: Indicates whether "Dispose" has already been called.
        /// </summary>
        private bool _disposed;

        /// <summary>
        /// SQL-скрипт для создания БД.
        /// </summary>
        protected virtual string ClickHouseSqlScript
        {
            get
            {
                return Resources.ClickHouseDirectGenerator_create;
            }
        }

        /// <summary>
        /// Data services for temp databases.
        /// </summary>
        protected IEnumerable<IDataService> DataServices
        {
            get
            {
                if (_disposed)
                {
                    throw new ObjectDisposedException(null);
                }

                return _dataServices;
            }
        }

        static BaseIntegratedTest()
        {
            // ADO.NET doesn't close the connection with pooling. We have to disable it explicitly.
            // http://stackoverflow.com/questions/9033356/connection-still-idle-after-close
            connectionStringClickHouse = ConfigurationManager.ConnectionStrings["ConnectionStringClickHouse"]?.ConnectionString;

            Assert.NotNull(connectionStringClickHouse);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseIntegratedTest" /> class.
        /// </summary>
        /// <param name="tempDbNamePrefix">Prefix for temp database name.</param>
        protected BaseIntegratedTest(string tempDbNamePrefix)
        {
            if (!(tempDbNamePrefix != null))
            {
                throw new ArgumentNullException();
            }

            if (!(tempDbNamePrefix != string.Empty))
            {
                throw new ArgumentException();
            }

            if (!tempDbNamePrefix.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException();
            }

            _tempDbNamePrefix = tempDbNamePrefix;
            _databaseName = _tempDbNamePrefix + "_" + DateTime.Now.ToString("yyyyMMddHHmmssff") + "_" + Guid.NewGuid().ToString("N");
            bool watchdogEmptyTest = false;

            if (!string.IsNullOrWhiteSpace(ClickHouseSqlScript) && connectionStringClickHouse != poolingFalseConst)
            {
                if (!(tempDbNamePrefix.Length <= 12)) // Max length is 63 (-18 -32).
                {
                    throw new ArgumentException();
                }

                if (!char.IsLetter(tempDbNamePrefix[0])) // Database names must have an alphabetic first character.
                {
                    throw new ArgumentException();
                }

                watchdogEmptyTest = true;

                using (var conn = new ClickHouseConnection($"{connectionStringClickHouse}"))
                {
                    conn.Open();
                    using (var cmd = new ClickHouseCommand(conn, $"CREATE DATABASE \"{_databaseName}\""))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                using (var conn = new ClickHouseConnection($"{connectionStringClickHouse};Database={_databaseName}"))
                {
                    conn.Open();

                    string[] createTableCommands = ClickHouseSqlScript.Split(';');

                    foreach (string createTableCommand in createTableCommands)
                    {
                        if (string.IsNullOrWhiteSpace(createTableCommand))
                        {
                            continue;
                        }

                        using (var cmd = new ClickHouseCommand(conn, createTableCommand))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    _dataServices.Add(CreateClickHouseDataService($"{connectionStringClickHouse};Database={_databaseName}"));
                }
            }

            Assert.True(watchdogEmptyTest);
        }

        /// <summary>
        /// Creates the <see cref="PostgresDataService"/> instance for temp database.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <returns>The <see cref="PostgresDataService"/> instance.</returns>
        protected virtual ClickHouseDataService CreateClickHouseDataService(string connectionString)
        {
            return new ClickHouseDataService { CustomizationString = connectionString };
        }

        /// <summary>
        /// Deletes the temporary databases and perform other cleaning.
        /// </summary>
        /// <param name="disposing">Flag: indicates whether method is calling from "Dispose()" or not.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                try
                {
                    foreach (var ds in _dataServices)
                    {
                        if (ds is ClickHouseDataService)
                        {
                            using (var connection = new ClickHouseConnection(connectionStringClickHouse))
                            {
                                connection.Open();
                                using (var command = connection.CreateCommand())
                                {
                                    command.CommandText = $"DROP DATABASE \"{_databaseName}\";";
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            _disposed = true;
        }

        /// <summary>
        /// Deletes the temporary databases and perform other cleaning.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }
    }
}
