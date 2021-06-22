namespace NewPlatform.ClickHouseDataService.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading;
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
                string value = "ууцуц\\уцуцу";

                StoredClass storedClass = new StoredClass() { StoredProperty = value };

                // Act.
                dataService.UpdateObject(storedClass);

                // Assert.

                // Wait for buffer sync. By default max time for start sync is 2 seconds.
                Thread.Sleep(3000);

                dataService.LoadObject(storedClass);

                Assert.Equal(value, storedClass.StoredProperty);
            }
        }

        /// <summary>
        /// Test for data with single quotes insertion.
        /// </summary>
        [Fact]
        public void InsertSingleQuotesTest()
        {
            foreach (IDataService dataService in DataServices)
            {
                // Arrange.
                string value = "ууцуц'уцуцу";

                StoredClass storedClass = new StoredClass() { StoredProperty = value };

                // Act.
                dataService.UpdateObject(storedClass);

                // Assert.

                // Wait for buffer sync. By default max time for start sync is 2 seconds.
                Thread.Sleep(3000);

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

                (dataService as SQLDataService).OnCreateCommand += (object sender, CreateCommandEventArgs e) =>
                {
                    string command = e.Command.CommandText;
                };

                StoredClass storedClass = new StoredClass() { StoredProperty = value };

                // Act.
                dataService.UpdateObject(storedClass);

                // Assert.

                // Wait for buffer sync. By default max time for start sync is 2 seconds.
                Thread.Sleep(3000);

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

                // Wait for buffer sync. By default max time for start sync is 2 seconds.
                Thread.Sleep(3000);

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

                int count = 100000;

                stopwatch.Start();
                List<StoredClass> storedClasses = new List<StoredClass>();

                for (int i = 0; i < count; i++)
                {
                    StoredClass storedClass = new StoredClass() { StoredProperty = value + i + "_" + random.Next(count / 2) };
                    storedClasses.Add(storedClass);
                }

                // Act.
                DataObject[] objs = storedClasses.ToArray();
                dataService.UpdateObjects(ref objs);

                stopwatch.Stop();

                Console.WriteLine($"It take {stopwatch.ElapsedMilliseconds}ms for write {count} object to storage.");

                // Assert.

                // Wait for buffer sync. By default max time for start sync is 2 seconds.
                Thread.Sleep(3000);

                // Check data count.
                View view = new View() { DefineClassType = typeof(StoredClass), Name = "v" };
                view.AddProperty(nameof(StoredClass.StoredProperty));
                LoadingCustomizationStruct lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(StoredClass), view);

                int actualCount = dataService.GetObjectsCount(lcs);

                Assert.Equal(count, actualCount);
            }
        }
    }
}
