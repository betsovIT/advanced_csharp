using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }

                people.Add(new Person(input[0], int.Parse(input[1]), input[2]));
            }

            int personIndex = int.Parse(Console.ReadLine());
            if (personIndex > people.Count-1)
            {
                Console.WriteLine("No matches");
                return;
            }
            var personToCompare = people[personIndex];

            int equalPersons = 0;
            int differentPerson = 0;

            for (int i = 0; i < people.Count; i++)
            {

                    if (personToCompare.CompareTo(people[i]) == 0)
                    {
                        equalPersons++;
                    }
                    else
                    {
                        differentPerson++;
                    }
            }


            if (equalPersons > 0)
            {
                Console.WriteLine($"{equalPersons} {differentPerson} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
