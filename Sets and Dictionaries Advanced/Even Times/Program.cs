using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            var collection = new Dictionary<int, int>();
            for (int i = 0; i < entries; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!collection.ContainsKey(input))
                {
                    collection.Add(input, 0);
                }
                collection[input]++;
            }
            foreach (var num in collection)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                }
            }
        }
    }
}
