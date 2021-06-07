namespace NewPlatform.Flexberry.ORM
{
    using System;
    using System.Data;
    using ICSSoft.STORMNET.Business;

    /// <summary>
    /// Empty db transaction wrapper for ClickHouse.
    /// </summary>
    public class EmptyDbTransactionWrapper : DbTransactionWrapper
    {
        /// <summary>
        /// Initializes instance of <see cref="DbTransactionWrapper" />.
        /// </summary>
        /// <param name="dataService">The instance of <see cref="SQLDataService" /> class.</param>
        public EmptyDbTransactionWrapper(SQLDataService dataService)
            : base(dataService)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DbTransactionWrapper" /> class by <see cref="IDbConnection" /> and <see cref="IDbTransaction" />.
        /// </summary>
        /// <param name="connection">An object representing an open connection to a data source.</param>
        /// <param name="transaction">An object representing the transaction.</param>
        public EmptyDbTransactionWrapper(IDbConnection connection, IDbTransaction transaction = null)
            : base(connection, transaction ?? GetTransaction())
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Returns <c>null</c>.
        /// </summary>
        public new IDbTransaction Transaction => GetTransaction();

        private static IDbTransaction GetTransaction()
        {
            return new FakeDbTransaction();
        }

        /// <inheritdoc/>
        public override void Dispose()
        {
            if (Connection?.State == ConnectionState.Open)
            {
                Connection.Close();
            }

            base.Dispose();
        }
    }
}
