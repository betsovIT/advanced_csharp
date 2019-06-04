using System;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boundaries = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string condition = Console.ReadLine();
            Predicate<string> conditionTester = n => n == "even";
            if (conditionTester(condition))
            {
                for (int i = boundaries[0]; i <= boundaries[1]; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = boundaries[0]; i <= boundaries[1]; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
