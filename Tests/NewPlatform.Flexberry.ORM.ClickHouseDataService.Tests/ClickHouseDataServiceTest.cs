namespace NewPlatform.ClickHouseDataService.Tests
{
    using Xunit;

    /// <summary>
    /// Test for <see cref="ClickHouseDataService"/>.
    /// </summary>
    public class ClickHouseDataServiceTest : BaseIntegratedTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClickHouseDataServiceTest"/> class.
        /// </summary>
        /// <param name="databasePrefix">Test database name prefix.</param>
        public ClickHouseDataServiceTest(string databasePrefix)
            : base(databasePrefix)
        {
        }

        /// <summary>
        /// Test for data insertion.
        /// </summary>
        [Fact]
        void InsertDataTest()
        {
            // TODO: implement this method.
        }
    }
}
