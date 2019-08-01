using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class DummyTests
    {
        [Test]
        public void DummyLoosesHealthIfAttacked()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(200, 100);

            axe.Attack(dummy);

            Assert.That(dummy.Health, Is.EqualTo(190));
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Axe axe = new Axe(20, 10);
            Dummy dummy = new Dummy(15, 100);

            axe.Attack(dummy);

            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(-5, 10);

            int experience = dummy.GiveExperience();

            Assert.That(experience, Is.EqualTo(10));
        }

        [Test]
        public void AliveDummyCanNotGiveXP()
        {
            Dummy dummy = new Dummy(5, 10);

            Assert.That(() => dummy.GiveExperience(), Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
        }
    }
}
