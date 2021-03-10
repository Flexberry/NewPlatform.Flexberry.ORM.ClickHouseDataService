namespace NewPlatform.Flexberry.ORM
{
    using System.Data;

    /// <summary>
    /// Fake IDbTransaction for not transaction storage.
    /// </summary>
    public sealed class FakeDbTransaction : IDbTransaction
    {
        /// <inheritdoc/>
        public IDbConnection Connection { get; set; }

        /// <inheritdoc/>
        public IsolationLevel IsolationLevel { get; set; }

        /// <inheritdoc/>
        public void Commit()
        {
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (Connection?.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        /// <inheritdoc/>
        public void Rollback()
        {
        }
    }
}
