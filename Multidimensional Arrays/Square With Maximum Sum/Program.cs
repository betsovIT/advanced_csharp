using System;
using System.Linq;

namespace Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split(", ", StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            int[,] arr = new int[dim[0], dim[1]];

            for (int i = 0; i < dim[0]; i++)
            {
                int[] token = Console.ReadLine()
                    .Split(", ", StringSplitOptions.None)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < dim[1]; j++)
                {
                    arr[i, j] = token[j];
                }
            }

            int maxSum = int.MinValue;
            int[,] arrToPrint = new int[2, 2];

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (arr[i, j] + arr[i, j + 1] + arr[i + 1, j] + arr[i + 1, j + 1] > maxSum)
                    {
                        maxSum = arr[i, j] + arr[i, j + 1] + arr[i + 1, j] + arr[i + 1, j + 1];
                        arrToPrint[0, 0] = arr[i, j];
                        arrToPrint[0, 1] = arr[i, j + 1];
                        arrToPrint[1, 0] = arr[i + 1, j];
                        arrToPrint[1, 1] = arr[i + 1, j + 1];
                    }
                }
            }

            Console.WriteLine($"{arrToPrint[0,0]} {arrToPrint[0, 1]}");
            Console.WriteLine($"{arrToPrint[1, 0]} {arrToPrint[1, 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
