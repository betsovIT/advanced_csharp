using System;
using System.Linq;

namespace Sum_Matrix_Columns
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

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = tokens[j];
                }
            }

            for (int i = 0; i < dim[1]; i++)
            {
                int sum = 0;
                for (int j = 0; j < dim[0]; j++)
                {
                    sum += arr[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
