using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities
{
    class Tank : BaseMachine, ITank
    {
        private const double initialHealthPoints = 100;
        private const double attackPointsDelta = 40;
        private const double deffencePointsDelta = 30;

        public Tank(string name, double attackPoints, double deffencePoints)
            : base(name, attackPoints, deffencePoints, initialHealthPoints)
        {
            ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (DefenseMode == true)
            {
                DefenseMode = false;
                this.AttackPoints += attackPointsDelta;
                this.DefensePoints -= deffencePointsDelta;
            }
            else
            {
                DefenseMode = true;
                this.AttackPoints -= attackPointsDelta;
                this.DefensePoints += deffencePointsDelta;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Defense: {(DefenseMode == true ? "ON" : "OFF")}");

            return sb.ToString().TrimEnd();
        }
    }
}
