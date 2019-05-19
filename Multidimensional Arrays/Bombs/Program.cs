using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = tokens[j];
                }
            }

            string[] coordinates = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] pairCoordinates = coordinates[i]
                                        .Split(',')
                                        .Select(int.Parse)
                                        .ToArray();
                int row = pairCoordinates[0];
                int coll = pairCoordinates[1];
                
                if (AreValidCoordinates(row - 1, coll - 1, matrix) && matrix[row - 1, coll - 1] > 0)
                {
                    matrix[row - 1, coll - 1] -= matrix[row, coll];
                }
                if (AreValidCoordinates(row - 1, coll, matrix) && matrix[row - 1, coll] > 0)
                {
                    matrix[row - 1, coll] -= matrix[row, coll];
                }
                if (AreValidCoordinates(row - 1, coll + 1, matrix) && matrix[row - 1, coll + 1] > 0)
                {
                    matrix[row - 1, coll + 1] -= matrix[row, coll];
                }
                if (AreValidCoordinates(row, coll - 1, matrix) && matrix[row, coll - 1] > 0)
                {
                    matrix[row, coll - 1] -= matrix[row, coll];
                }
                if (AreValidCoordinates(row, coll + 1, matrix) && matrix[row, coll + 1] > 0)
                {
                    matrix[row, coll + 1] -= matrix[row, coll];
                }
                if (AreValidCoordinates(row + 1, coll - 1, matrix) && matrix[row + 1, coll - 1] > 0)
                {
                    matrix[row + 1, coll - 1] -= matrix[row, coll];
                }
                if (AreValidCoordinates(row + 1, coll, matrix) && matrix[row + 1, coll] > 0)
                {
                    matrix[row + 1, coll] -= matrix[row, coll];
                }
                if (AreValidCoordinates(row + 1, coll + 1, matrix) && matrix[row + 1, coll + 1] > 0)
                {
                    matrix[row + 1, coll + 1] -= matrix[row, coll];
                }

                matrix[row, coll] = 0;                
            }
            int aliveCells = 0;
            long sumOfAliveCells = 0;
            foreach (int num in matrix)
            {
                if (num > 0)
                {
                    aliveCells++;
                    sumOfAliveCells += num;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumOfAliveCells}");
            PrintMatrix(matrix);
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static bool AreValidCoordinates(int row, int coll, int[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && coll >= 0 && coll < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
