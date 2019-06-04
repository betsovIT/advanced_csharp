using System;
using System.Linq;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int specialNum = int.Parse(Console.ReadLine());
            Func<int, int, bool> tester = (x, y) => x % y != 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (tester(nums[i],specialNum))
                {
                    Console.Write($"{nums[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
