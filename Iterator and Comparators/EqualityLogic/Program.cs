using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleInHashSet = new HashSet<Person>();
            var peopleInSortedSet = new SortedSet<Person>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();
                var person = new Person(input[0], input[1]);

                peopleInHashSet.Add(person);
                peopleInSortedSet.Add(person);
            }

            Console.WriteLine(peopleInSortedSet.Count);
            Console.WriteLine(peopleInHashSet.Count);
        }
    }
}
