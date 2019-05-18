using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[squareMatrixSize, squareMatrixSize];

            for (int i = 0; i < squareMatrixSize; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < squareMatrixSize; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            int primeDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < squareMatrixSize; i++)
            {
                for (int j = 0; j < squareMatrixSize; j++)
                {
                    if (i == j)
                    {
                        primeDiagonalSum += matrix[i, j];
                    }
                }
            }

            for (int i = 0; i < squareMatrixSize; i++)
            {
                for (int j = squareMatrixSize - 1; j >= 0; j--)
                {
                    if (i + j == squareMatrixSize - 1)
                    {
                        secondaryDiagonalSum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine(Math.Abs(primeDiagonalSum-secondaryDiagonalSum));
        }
    }
}
