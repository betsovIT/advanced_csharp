using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    class Repository
    {
        private int counter;
        private Dictionary<int, Person> people;

        public Repository()
        {
            people = new Dictionary<int, Person>();
            counter = 0;
        }

        public int Count
        {
            get
            { return people.Count; }
        }

        public void Add(Person person)
        {
            people.Add(counter, person);
            counter++;
        }

        public Person Get(int id)
        {
            if (people.ContainsKey(id))
            {
                return people[id];
            }

            return null;
        }

        public bool Update(int id, Person newPerson)
        {
            if (people.ContainsKey(id))
            {
                people[id] = newPerson;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            if (people.ContainsKey(id))
            {
                people.Remove(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
