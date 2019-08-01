using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    
    public class AxeTests
    {
        [Test]
        public void AxeLoosesDurabilityAfterAttack()
        {
            Axe axe = new Axe(10, 20);
            Dummy dummy = new Dummy(200, 0);

            axe.Attack(dummy);

            Assert.That(axe.DurabilityPoints, Is.EqualTo(19));

        }
    }
}
