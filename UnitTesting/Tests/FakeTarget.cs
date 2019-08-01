using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class FakeTarget : ITarget
    {
        public int Health => 0;

        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
            return true;
        }

        public void TakeAttack(int attackPoints)
        {
            
        }
    }
}
