using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class FakeWeapon : IWeapon
    {
        public int AttackPoints => 0;

        public int DurabilityPoints => 0;

        public void Attack(ITarget traget)
        {
            
        }
    }
}
