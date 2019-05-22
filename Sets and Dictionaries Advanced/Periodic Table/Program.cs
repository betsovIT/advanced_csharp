using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            var periodicTable = new SortedSet<string>();
            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (string element in input)
                {
                    periodicTable.Add(element);
                }
            }
            Console.WriteLine(string.Join(' ',periodicTable));
        }
    }
}
