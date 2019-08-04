using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    [TestFixture]
    public class RaceEntryTests
    {
        [Test]
        public void TestThatRaceEntryInitializesCollectionCorrectly()
        {
            var entry = new RaceEntry();
            Assert.That(entry.Counter == 0);
        }

        [Test]
        public void TestAddingNullRider()
        {
            var entry = new RaceEntry();
            UnitRider rider = null;

            Assert.Throws<InvalidOperationException>(() => entry.AddRider(rider), "Rider cannot be null.");
        }
    }
}