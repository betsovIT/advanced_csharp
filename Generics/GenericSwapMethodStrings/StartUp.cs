using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new GenericList<string>();

            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                string input = Console.ReadLine();
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
