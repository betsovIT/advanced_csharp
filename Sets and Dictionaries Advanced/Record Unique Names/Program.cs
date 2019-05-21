using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            var uniqueNames = new HashSet<string>();
            for (int i = 0; i < entries; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }
            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
