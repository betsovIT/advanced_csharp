using NUnit.Framework;
using FightingArena;
using System;

namespace Tests
{
    [TestFixture]
    public class WarriorTests
    {
        [Test]
        public void TestNameIsSetCorrectly()
        {
            Warrior warrior = new Warrior("Pesho", 10, 100);

            Assert.That(warrior.Name, Is.EqualTo("Pesho"));
        }

        [Test]
        public void TestSettingNameToNull()
        {
            Assert.Throws<ArgumentException>(() => new Warrior(null, 20, 100));
        }
        
        [Test]
        public void TestSettingNameToWhitespace()
        {
            Assert.Throws<ArgumentException>(() => new Warrior(" ", 20, 100));
        }

        [Test]
        public void TestDamageIsSetCorreclty()
        {
            Warrior warrior = new Warrior("Pesho", 10, 100);

            Assert.That(warrior.Damage, Is.EqualTo(10));
        }
        [Test]
        public void TestSettingDamageToZero()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Bai Mangal", 0, 100));
        }

        [Test]
        public void TestSettingDamageToNegative()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Bai Mangal", -5, 100));
        }

        [Test]
        public void TestHPIsSetCorrectly()
        {
            Warrior warrior = new Warrior("Pesho", 10, 100);

            Assert.That(warrior.HP, Is.EqualTo(100));
        }
        [Test]
        public void TestSettingHpToNegative()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Bai Mangal", 20, -5));
        }

        [Test]
        public void TestAttackinWithHPLowerThan30()
        {
            Warrior warrior = new Warrior("Pesho", 20, 150);
            Warrior warriorToBeTested = new Warrior("Gosho", 20, 25);

            Assert.Throws<InvalidOperationException>(() => warriorToBeTested.Attack(warrior));
        }

        [Test]
        public void TestAttackingTargetWithHPLowerThan30()
        {
            Warrior warriorA = new Warrior("Pesho", 20, 150);
            Warrior warriorB = new Warrior("Gosho", 20, 25);

            Assert.Throws<InvalidOperationException>(() => warriorA.Attack(warriorB));
        }

        [Test]
        public void TestAttackingStrongerEnemies()
        {
            Warrior warriorA = new Warrior("Pesho", 20, 35);
            Warrior warriorB = new Warrior("Gosho", 40, 50);

            Assert.Throws<InvalidOperationException>(() => warriorA.Attack(warriorB), "You are trying to attack too strong enemy");
        }

        [Test]
        public void TestSettingHPToZeroWhenDamageIsGreaterThanHP()
        {
            Warrior warriorA = new Warrior("Pesho", 20, 35);
            Warrior warriorB = new Warrior("Gosho", 40, 60);

            warriorB.Attack(warriorA);

            Assert.That(warriorA.HP, Is.EqualTo(0));
        }

        [Test]
        public void TestHpAfterAttack()
        {
            Warrior warriorA = new Warrior("Pesho", 20, 60);
            Warrior warriorB = new Warrior("Gosho", 40, 50);

            warriorA.Attack(warriorB);

            Assert.That(warriorA.HP, Is.EqualTo(20));
            Assert.That(warriorB.HP, Is.EqualTo(30));
        }
    }
}