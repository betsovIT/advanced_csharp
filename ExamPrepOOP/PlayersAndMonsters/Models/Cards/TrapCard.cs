using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card
    {
        private const int initialDamage = 120;
        private const int initialHealth = 5;
        public TrapCard(string name)
            : base(name, initialDamage, initialHealth)
        {
        }
    }
}
