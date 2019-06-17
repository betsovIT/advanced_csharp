using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLake = new Lake(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            var temList = new List<int>();

            foreach (var item in myLake)
            {
                temList.Add(item);
            }

            Console.WriteLine(string.Join(", ", temList));
        }
    }
}
