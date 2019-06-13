using System;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();

            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            list.Swap(indexes[0], indexes[1]);

            Console.WriteLine(list.ToString());
        }
    }
}
