using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    class Salad
    {
        public List<Vegetable> Ingridients { get; private set; }
        public string Name { get; set; }

        public Salad(string name)
        {
            Name = name;
            Ingridients = new List<Vegetable>();
        }

        public int GetTotalCalories()
        {
            return Ingridients.Sum(n => n.Calories);
        }
        public int GetProductCount()
        {
            return Ingridients.Count;
        }
        public void Add(Vegetable vegetable)
        {
            Ingridients.Add(vegetable);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"* Salad {Name} is {this.GetTotalCalories()} calories and have {this.GetProductCount()} products:");
            foreach (var vegie in Ingridients)
            {
                sb.AppendLine(vegie.ToString());
            }

            return sb.ToString();
        }

    }
}
