using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    class Item
    {
        private int strength;
        private int ability;
        private int inteligence;

        public int Strength
        {
            get
            {
                return this.strength;
            }
            set
            {
                this.strength = value;
            }
        }

        public int Ability
        {
            get
            {
                return this.ability;
            }
            set
            {
                this.ability = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return this.inteligence;
            }
            set
            {
                this.inteligence = value;
            }
        }

        public Item(int strength, int ability, int inteligence)
        {
            this.strength = strength;
            this.ability = ability;
            this.inteligence = inteligence;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Item:");
            sb.AppendLine($"    * Strength: {this.strength}");
            sb.AppendLine($"    * Ability: {this.ability}");
            sb.AppendLine($"    * Inteligence: {this.inteligence}");

            return sb.ToString();
        }
    }
}
