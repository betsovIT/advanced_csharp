using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    class Citizen : IPerson, IResident
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public int Age { get; set; }

        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = Age;
        }

        string IPerson.GetName()
        {
            return $"{Name}";
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }
    }
}
