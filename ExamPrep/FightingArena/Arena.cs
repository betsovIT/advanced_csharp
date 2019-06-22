using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    class Arena
    {
        private Dictionary<string, Gladiator> gladiators;
        public string Name { get; set; }

        public int Count => gladiators.Count;

        public Arena(string name)
        {
            Name = name;
            gladiators = new Dictionary<string, Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator.Name, gladiator);
        }
        public void Remove(string gladiator)
        {
            gladiators.Remove(gladiator);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return gladiators.Where(n => n.Value.GetStatPower() == gladiators.Values.Max(s => s.GetStatPower())).FirstOrDefault().Value;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return gladiators.Where(n => n.Value.GetWeaponPower() == gladiators.Values.Max(s => s.GetWeaponPower())).FirstOrDefault().Value;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return gladiators.Where(n => n.Value.GetTotalPower() == gladiators.Values.Max(s => s.GetTotalPower())).FirstOrDefault().Value;
        }

        public override string ToString()
        {
            return $"{this.Name} - {gladiators.Count} gladiators are participating.";
        }
    }
}
