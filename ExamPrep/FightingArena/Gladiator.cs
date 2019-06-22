using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    class Gladiator
    {
        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public int GetTotalPower()
        {
            int weaponTotalPower = this.Weapon.Sharpness + this.Weapon.Size + this.Weapon.Solidity;
            int statTotalPower = this.Stat.Agility + this.Stat.Flexibility + this.Stat.Intelligence + this.Stat.Skills + this.Stat.Strength;

            return weaponTotalPower + statTotalPower;
        }

        public int GetWeaponPower()
        {
            int weaponTotalPower = this.Weapon.Sharpness + this.Weapon.Size + this.Weapon.Solidity;
            return weaponTotalPower;
        }

        public int GetStatPower()
        {
            int statTotalPower = this.Stat.Agility + this.Stat.Flexibility + this.Stat.Intelligence + this.Stat.Skills + this.Stat.Strength;
            return statTotalPower;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} - {this.GetTotalPower()}");
            sb.AppendLine($"  Weapon Power: {this.GetWeaponPower()}");
            sb.AppendLine($"  Stat Power: {this.GetStatPower()}");

            return sb.ToString();
        }
    }
}
