using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] arr = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = tokens[j];
                }
            }

            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
