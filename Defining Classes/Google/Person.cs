using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    class Person
    {
        public string Name { get; set; }
        public Company Company { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Child> Children { get; set; }
        public Car Car { get; set; }

        public Person(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();

        }

        public Person(string name, Company company)
            : this(name)
        {
            this.Company = company;
        }

        public Person(string name, Pokemon pokemon)
            : this(name)
        {
            this.Pokemons.Add(pokemon);
        }

        public Person(string name, Parent parent)
            : this(name)
        {
            this.Parents.Add(parent);
        }

        public Person(string name, Child child)
            : this(name)
        {
            this.Children.Add(child);
        }

        public Person(string name, Car car)
            : this(name)
        {
            this.Car = car;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name}");
            sb.AppendLine("Company:");
            sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary.ToString()}");
            sb.AppendLine("Car:");
            sb.AppendLine($"{this.Car.Model} {this.Car.Speed.ToString()}");
            foreach (var pokemon in this.Pokemons)
            {
                sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
            }
            foreach (var parent in this.Parents)
            {
                sb.AppendLine($"{parent.Name} {parent.Birthday}");
            }
            foreach (var child in this.Children)
            {
                sb.AppendLine($"{child.Name} {child.Birthday}");
            }

            return sb.ToString();
        }

    }
}
