using System;
using System.Collections.Generic;

namespace EnterNumbers
{
    class Program
    {
        public const int start = 1;
        public const int end = 100;

        static void Main(string[] args)
        {
            var numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    var num = ReadNumber(start, end);
                    numbers[i] = num;

                    if (i > 0 && numbers[i] < numbers[i-1])
                    {
                        Console.WriteLine("Number can't descend! Start again.");
                        i = -1;
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i = 0;
                    continue;
                }
            }

            Console.WriteLine($"Your numbers are: {string.Join(", ",numbers)}");

        }
        public static int ReadNumber(int start, int end)
        {
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                throw new ArgumentException("This is not an integer number!");
            }

            if (num <= start || num >= end)
            {
                throw new ArgumentOutOfRangeException("Number is not in the desired range.");
            }

            return num;
        }
    }


}
