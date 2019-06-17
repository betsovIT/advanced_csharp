using System;
using System.Collections.Generic;
using System.Text;

namespace EqualityLogic
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name,string age)
        {
            Name = name;
            Age = int.Parse(age);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person p = (Person)obj;

                if (this.Name == p.Name && this.Age == p.Age)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override int GetHashCode()
        {
            int sum = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                sum += Name[i];
            }
            sum += Age;

            return sum;
        }

        public int CompareTo(Person other)
        {
            int result;
            result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }
    }
}
