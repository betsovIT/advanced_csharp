using System;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var sortedNums = nums.OrderBy(x => x % 2 != 0).ThenBy(x => x);

            Func<int, int, int> evaluator = (a, b) =>
            {
                if (a % 2 == 0 && b % 2 != 0)
                {
                    return -1;
                }
                else if (a % 2 != 0 && b % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return a.CompareTo(b);
                }
            };

            Array.Sort(nums, new Comparison<int>(evaluator));
            Console.WriteLine(string.Join(' ', nums));
        }

    }
}
