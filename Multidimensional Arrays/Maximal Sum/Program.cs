using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimm = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).
                ToArray();

            int[,] matrix = new int[dimm[0], dimm[1]];
            int[,] maxMatrix = new int[3, 3];
            int maxMatrixSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tokens[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    if (matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                                + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                                    + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2] > maxMatrixSum)
                    {
                        maxMatrixSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                                + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                                    + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                        maxMatrix[0, 0] = matrix[i, j];
                        maxMatrix[0, 1] = matrix[i, j + 1];
                        maxMatrix[0, 2] = matrix[i, j + 2];
                        maxMatrix[1, 0] = matrix[i + 1, j];
                        maxMatrix[1, 1] = matrix[i + 1, j + 1];
                        maxMatrix[1, 2] = matrix[i + 1, j + 2];
                        maxMatrix[2, 0] = matrix[i + 2, j];
                        maxMatrix[2, 1] = matrix[i + 2, j + 1];
                        maxMatrix[2, 2] = matrix[i + 2, j + 2];
                    }
                }
            }

            Console.WriteLine($"Sum = {maxMatrixSum}");
            for (int i = 0; i < maxMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < maxMatrix.GetLength(1); j++)
                {
                    Console.Write($"{maxMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
