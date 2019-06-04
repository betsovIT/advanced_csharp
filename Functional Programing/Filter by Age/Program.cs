using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();
            for (int i = 0; i < entries; i++)
            {
                string input = Console.ReadLine();
                string name = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)[0];
                int age = int.Parse(input.Split(", ", StringSplitOptions.RemoveEmptyEntries)[1]);

                people.Add(name, age);
            }
            string olderOrYounger = Console.ReadLine();
            int arbitraryAge = int.Parse(Console.ReadLine());
            string whatToPrint = Console.ReadLine();
            
            foreach (var person in people.Where(p => olderOrYounger == "older" ? p.Value >= arbitraryAge : p.Value < arbitraryAge))
            {
                Printer(person, whatToPrint);
            }
        }
        public static void Printer (KeyValuePair<string,int> person,string rule)
        {
            if (rule == "name")
            {
                Console.WriteLine(person.Key);
            }
            else if (rule == "age")
            {
                Console.WriteLine(person.Value);
            }
            else if (rule == "name age")
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }
        }
    }
}
