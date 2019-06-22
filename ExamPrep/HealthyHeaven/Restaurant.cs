using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    class Restaurant
    {
        public List<Salad> Salads { get; set; }
        public string Name { get; set; }

        public Restaurant(string name)
        {
            Name = name;
            Salads = new List<Salad>();
        }

        public void Add(Salad salad)
        {
            Salads.Add(salad);
        }

        public bool Buy(string salad)
        {
            return Salads.Remove(Salads.Where(n => n.Name == salad).FirstOrDefault());
        }

        public Salad GetHealthiestSalad()
        {
            return Salads.Where(n => n.Ingridients.Sum(s => s.Calories) == Salads.Min(x => x.Ingridients.Sum(p => p.Calories))).FirstOrDefault();
        }

        public string GenerateMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" {Name} have {Salads.Count} salads:");
            foreach (var salad in Salads)
            {
                sb.AppendLine(salad.ToString());
            }

            return sb.ToString();
        }
    }
}
