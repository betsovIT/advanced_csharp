using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> nums = new Dictionary<double, int>();

            double[] values = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (double number in values)
            {
                if (!nums.ContainsKey(number))
                {
                    nums.Add(number, 0);
                }

                nums[number]++;
            }

            foreach (var key in nums)
            {
                Console.WriteLine($"{key.Key} - {key.Value} times");
            }
        }
    }
}
