﻿using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> minValueFinder = n => n.Min();
            Console.WriteLine(minValueFinder(nums));
        }
    }
}
