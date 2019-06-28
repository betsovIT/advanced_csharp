using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private Dictionary<string, Astronaut> data;
        public string Name { get; private set; }
        public int Capacity { get; private set; }

        public int Count => data.Count;

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new Dictionary<string, Astronaut>();
        }

        public void Add(Astronaut astronaut)
        {
            if (data.Count < Capacity)
            {
                data.Add(astronaut.Name, astronaut);
                Capacity++;
            }
        }

        public bool Remove(string name)
        {
            if (data.ContainsKey(name))
            {
                Capacity--;
                return data.Remove(name);
            }
            else
            {
                return false;
            }
        }

        public Astronaut GetOldestAstronaut()
        {
            return data.Where(n => n.Value.Age == data.Values.Max(s => s.Age)).FirstOrDefault().Value;
        }

        public Astronaut GetAstronaut(string name)
        {
            if (data.ContainsKey(name))
            {
                return data[name];
            }
            else
            {
                return null;
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var person in data)
            {
                sb.Append($"Astronaut: ");
                sb.AppendLine(person.Value.ToString());
            }
            return sb.ToString();
        }

    }
}
