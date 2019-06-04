using System;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        public delegate int[] ArrayManipulator( int[] nums);
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = Manipulate(numbers, Add);
                }
                else if (command == "multiply")
                {
                    numbers = Manipulate(numbers, Multiply);
                }
                else if (command == "subtract")
                {
                    numbers = Manipulate(numbers, Substract);
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(' ',numbers));
                }
                command = Console.ReadLine();
            }
        }

        public static int[] Manipulate(int[] nums, ArrayManipulator opr)
        {
            return opr(nums);
        }
        public static int[] Add(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = ++nums[i];
            }
            return result;
        }
        public static int[] Substract(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = --nums[i];
            }
            return result;
        }
        public static int[] Multiply(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i]*2;
            }
            return result;
        }
    }
}
