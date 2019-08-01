using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities
{
    class Fighter : BaseMachine, IFighter
    {
        private const double initialHealthPoints = 200;
        private const double attackPointsDelta = 50;
        private const double deffencePointsDelta = 25;

        public Fighter(string name, double attackPoints, double deffencePoints)
            :base(name, attackPoints,deffencePoints,initialHealthPoints)
        {
            ToggleAggressiveMode();
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if (AggressiveMode == true)
            {
                AggressiveMode = false;
                this.AttackPoints -= attackPointsDelta;
                this.DefensePoints += deffencePointsDelta;

            }
            else
            {
                AggressiveMode = true;
                this.AttackPoints += attackPointsDelta;
                this.DefensePoints -= deffencePointsDelta;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Aggressive: {(AggressiveMode == true ? "ON" : "OFF")}");

            return sb.ToString().TrimEnd();
        }
    }
}
