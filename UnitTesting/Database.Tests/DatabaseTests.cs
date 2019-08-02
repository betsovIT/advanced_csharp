using NUnit.Framework;
using System;
using Database;

namespace Tests
{
    public class DatabaseTests
    {
        private Database.Database database;
        [SetUp]
        public void Setup()
        {
            database = new Database.Database(new int[] { 1, 2 });
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            int expectedCount = 2;

            Assert.AreEqual(expectedCount, database.Count);
        }

        [Test]
        public void TestAddingCorrectly()
        {
            int expectedCount = 3;

            this.database.Add(3);

            Assert.AreEqual(expectedCount, database.Count);
        }

        [Test]
        public void TestAddingWhenFull()
        {
            for (int i = 3; i < 17; i++)
            {
                database.Add(i);
            }

            Assert.That(() => database.Add(1), Throws.InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void TestRemovingCorrectly()
        {
            int expectedCount = 1;

            database.Remove();

            Assert.AreEqual(expectedCount, database.Count);
        }

        [Test]
        public void TestRemovingWhenEmpty()
        {
            database.Remove();
            database.Remove();

            Assert.Throws<InvalidOperationException>(() => database.Remove(), "The collection is empty!");
        }

        [Test]
        public void TestFetchWorksCorrectly()
        {
            int[] expected = new int[] { 1, 2 };
            int[] fetchedArray = database.Fetch();

            Assert.AreEqual(expected, fetchedArray);
        }
    }
}