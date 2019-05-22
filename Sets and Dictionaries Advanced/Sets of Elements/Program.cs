using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setSizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            for (int i = 0; i < setSizes[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < setSizes[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
