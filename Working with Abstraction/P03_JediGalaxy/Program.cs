using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimestions[0];
            int colls = dimestions[1];

            int[,] matrix = new int[rows, colls];

            //Filling the matrix with values
            int fillerCounter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    matrix[i, j] = fillerCounter++;
                }
            }

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoSCoordinates = command
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int[] evilCoordinates = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int evilRow = evilCoordinates[0];
                int evilCol = evilCoordinates[1];

                while (evilRow >= 0 && evilCol >= 0)
                {
                    if (ValidCoordinates(matrix, evilRow, evilCol))
                    {
                        matrix[evilRow, evilCol] = 0;
                    }
                    evilRow--;
                    evilCol--;
                }

                int ivoSRow = ivoSCoordinates[0];
                int ivoSCol = ivoSCoordinates[1];

                while (ivoSRow >= 0 && ivoSCol < matrix.GetLength(1))
                {
                    if (ValidCoordinates(matrix,ivoSRow,ivoSCol))
                    {
                        sum += matrix[ivoSRow, ivoSCol];
                    }

                    ivoSCol++;
                    ivoSRow--;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }

        private static bool ValidCoordinates(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
