using NUnit.Framework;
using FightingArena;
using System;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class ArenaTests
    {
        [Test]
        public void TestEnrollmentIncreasesCount()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Pesho", 10, 100);

            arena.Enroll(warrior);

            Assert.That(arena.Count, Is.EqualTo(1));
        }

        [Test]
        public void TestEnrollmentOfTheSameWarrior()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Pesho", 10, 100);

            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior), "Warrior is already enrolled for the fights!");
        }

        [Test]
        public void TestAttackWorksCorrectly()
        {
            Arena arena = new Arena();
            Warrior warriorGosho = new Warrior("Gosho", 10, 100);
            Warrior warriorPesho = new Warrior("Pesho", 20, 100);

            arena.Enroll(warriorGosho);
            arena.Enroll(warriorPesho);

            arena.Fight("Pesho", "Gosho");

            Assert.That(arena.Warriors.First(w => w.Name == "Gosho").HP, Is.EqualTo(80));
            Assert.That(arena.Warriors.First(w => w.Name == "Pesho").HP, Is.EqualTo(90));
        }

        [Test]
        public void TestAttackWithNonExistentWarrior()
        {
            Arena arena = new Arena();
            Warrior warriorGosho = new Warrior("Gosho", 10, 100);

            arena.Enroll(warriorGosho);

            Assert.Throws<InvalidOperationException>(() => arena.Fight("Gosho", "Petkan"), $"There is no fighter with name Petkan enrolled for the fights!");
        }
    }
}
