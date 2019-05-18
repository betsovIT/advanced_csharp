using System;
using System.Linq;

namespace Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimm = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] properteiesOfBomb = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[dimm[0], dimm[1]];
            int bombRow = properteiesOfBomb[0];
            int bombColl = properteiesOfBomb[1];
            int bombRadius = properteiesOfBomb[2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int relativeX = Math.Abs(bombRow - i);
                    int relativeY = Math.Abs(bombColl - j);

                    if (relativeX + relativeY <= bombRadius)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            //PrintMatrix(matrix);
            //Console.WriteLine();

            for (int j = Math.Max((bombColl - bombRadius),0); j < Math.Min(matrix.GetLength(1), (bombColl + bombRadius + 1)); j++)
            {
                while (matrix[0,j] < 1)
                {
                    for (int i = 0; i < matrix.GetLength(0)-1; i++)
                    {
                        matrix[i, j] = matrix[i + 1, j];
                    }
                    matrix[matrix.GetLength(0) - 1, j] = 0;
                }
            }



            PrintMatrix(matrix);
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
