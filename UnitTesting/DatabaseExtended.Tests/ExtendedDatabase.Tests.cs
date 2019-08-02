using NUnit.Framework;
using ExtendedDatabase;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase extendedDatabase;
        [SetUp]
        public void Setup()
        {
            extendedDatabase = new ExtendedDatabase.ExtendedDatabase(new Person(1, "Pesho"), new Person(2, "Gosho"), new Person(3, "Ivan"));
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            int expectedPeopleCount = 3;

            Assert.AreEqual(expectedPeopleCount, extendedDatabase.Count);
        }

        [Test]
        public void TestThatAddingWorksCorrectly()
        {
            var person = new Person(4, "Johny");
            extendedDatabase.Add(person);
            int expectedPeopleCount = 4;

            Assert.AreEqual(expectedPeopleCount, extendedDatabase.Count);
        }

        [Test]
        public void TestAddingWhenFull()
        {
            Person[] persons = new Person[]
            {
                new Person(4,"Ab"),
                new Person(5,"Ac"),
                new Person(6,"Ad"),
                new Person(7,"Ae"),
                new Person(8,"Af"),
                new Person(9,"Ag"),
                new Person(10,"Ah"),
                new Person(11,"Ai"),
                new Person(12,"Aj"),
                new Person(13,"Ak"),
                new Person(14,"Al"),
                new Person(15,"Am"),
                new Person(16,"An")
            };

            for (int i = 0; i < persons.Length; i++)
            {
                extendedDatabase.Add(persons[i]);
            }

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(new Person(18, "Ba")), "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void TestAddingPersonWithSameName()
        {
            Assert.That(() => extendedDatabase.Add(new Person(12, "Pesho")), Throws.InvalidOperationException.With.Message.EqualTo("There is already user with this username!"));
        }

        [Test]
        public void TestAddingPersonWithSameId()
        {
            Assert.That(() => extendedDatabase.Add(new Person(1, "Peter")), Throws.InvalidOperationException.With.Message.EqualTo("There is already user with this Id!"));
        }

        [Test]
        public void TestRemovingWorksCorrectly()
        {
            extendedDatabase.Remove();
            int expectedCount = 2;

            Assert.AreEqual(expectedCount, extendedDatabase.Count);
        }

        [Test]
        public void TestRemovingFromEmpty()
        {
            extendedDatabase.Remove();
            extendedDatabase.Remove();
            extendedDatabase.Remove();

            Assert.That(() => extendedDatabase.Remove(), Throws.InvalidOperationException);
        }

        [Test]
        public void TestIfFindingByUsernameWorksCorrectly()
        {
            string name = "Pesho";

            var person = extendedDatabase.FindByUsername(name);

            Assert.That(person.UserName, Is.EqualTo(name));
        }

        [Test]
        public void TestSearchingWithNullString()
        {
            string name = null;

            Assert.That(() => extendedDatabase.FindByUsername(name), Throws.ArgumentNullException);
        }

        [Test]
        public void TestSearchingWillNonexistantName()
        {
            string name = "Strahil";

            Assert.That(() => extendedDatabase.FindByUsername(name), Throws.InvalidOperationException.With.Message.EqualTo("No user is present by this username!"));
        }

        [Test]
        public void TestIfFindingByIDWorksCorrectly()
        {
            int id = 1;
            var person = extendedDatabase.FindById(id);

            Assert.That(person.UserName, Is.EqualTo("Pesho"));
        }

        [Test]
        public void TestSearchingWithNegativeId()
        {
            int id = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => extendedDatabase.FindById(id), "Id should be a positive number!");
        }

        [Test]
        public void TestSearchingWithNonexistendId()
        {
            int id = 203;
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindById(id), "No user is present by this ID!");
        }
    }
}