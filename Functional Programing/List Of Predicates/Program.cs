using System;
using System.Linq;

namespace List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int, bool> checkDivision = (x, y) => x % y == 0 ? true : false;

            for (int i = 1; i <= range; i++)
            {
                bool isToPrint = true;
                foreach (int num in divisors)
                {
                    isToPrint = checkDivision(i, num);
                    if(!isToPrint)
                    {
                        break;
                    }
                }

                if (isToPrint)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
