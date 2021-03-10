namespace NewPlatform.ClickHouseDataService.Tests
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
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
        public ClickHouseDataServiceTest()
            : base("InsTest")
        {
        }

        /// <summary>
        /// Test for data insertion.
        /// </summary>
        [Fact]
        public void InsertDataTest()
        {
            foreach (IDataService dataService in DataServices)
            {
                // Arrange.
                string value = "pro\\perty-value";

                StoredClass storedClass = new StoredClass() { StoredProperty = value };

                // Act.
                dataService.UpdateObject(storedClass);

                // Assert.
                dataService.LoadObject(storedClass);

                Assert.Equal(value, storedClass.StoredProperty);
            }
        }

        /// <summary>
        /// Test for data insertion.
        /// </summary>
        [Fact]
        public void InsertDataPerformanceTest()
        {
            foreach (IDataService dataService in DataServices)
            {
                // Arrange.
                string value = "property-value";
                Random random = new Random();
                Stopwatch stopwatch = new Stopwatch();

                int count = 1000;

                stopwatch.Start();

                for (int i = 0; i < count; i++)
                {
                    StoredClass storedClass = new StoredClass() { StoredProperty = value + i + "_" + random.Next(count / 2) };

                    // Act.
                    dataService.UpdateObject(storedClass);
                }

                stopwatch.Stop();

                Console.WriteLine(stopwatch.ElapsedMilliseconds);

                // Assert.
                View view = new View() { DefineClassType = typeof(StoredClass), Name = "v" };
                view.AddProperty(nameof(StoredClass.StoredProperty));
                LoadingCustomizationStruct lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(StoredClass), view);

                int actualCount = dataService.GetObjectsCount(lcs);

                Assert.Equal(count, actualCount);
            }
        }

    }
}
