namespace NewPlatform.ClickHouseDataService.Tests
{
    using System;
    using System.Diagnostics;
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
        /// Test for data with slash insertion.
        /// </summary>
        [Fact]
        public void InsertSlashDataTest()
        {
            foreach (IDataService dataService in DataServices)
            {
                // Arrange.
                string value = "ууцуц\\\\уцуцу";

                StoredClass storedClass = new StoredClass() { StoredProperty = value };

                // Act.
                dataService.UpdateObject(storedClass);

                // Assert.
                dataService.LoadObject(storedClass);

                Assert.Equal(value, storedClass.StoredProperty);
            }
        }

        /// <summary>
        /// Test for data with quotes insertion.
        /// </summary>
        [Fact]
        public void InsertQuotesDataTest()
        {
            foreach (IDataService dataService in DataServices)
            {
                // Arrange.
                string value = "[{\"field\":\"Field11\"}]";

                StoredClass storedClass = new StoredClass() { StoredProperty = value };

                // Act.
                dataService.UpdateObject(storedClass);

                // Assert.
                dataService.LoadObject(storedClass);

                Assert.Equal(value, storedClass.StoredProperty);
            }
        }

        /// <summary>
        /// Test for data with quotes insertion.
        /// </summary>
        [Fact]
        public void InsertHierarchicalDataTest()
        {
            foreach (IDataService dataService in DataServices)
            {
                // Arrange.
                string value = "Bobik";

                Dog dog = new Dog() { Name = value };

                // Act.
                dataService.UpdateObject(dog);

                // Assert.
                dataService.LoadObject(dog);

                Assert.Equal(value, dog.Name);
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

                int count = 10000;

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
