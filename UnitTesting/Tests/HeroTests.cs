using Moq;
using NUnit.Framework;
using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class HeroTests
    {
        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(p => p.Health).Returns(0);
            fakeTarget.Setup(p => p.IsDead()).Returns(true);
            fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero hero = new Hero("Pesho", fakeWeapon.Object);

            hero.Attack(fakeTarget.Object);

            Assert.That(hero.Experience, Is.EqualTo(20), "The hero doesn't recieve the correct ammount of XP");
        }
    }
}
