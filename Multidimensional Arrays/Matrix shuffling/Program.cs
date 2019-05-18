using System;
using System.Linq;

namespace Matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimm = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[dimm[0], dimm[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tokens[j];
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0].ToUpper() == "END")
                {
                    break;
                }

                if (input.Length > 5
                    || input.Length < 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string command = input[0];
                int row1 = int.Parse(input[1]);
                int col1 = int.Parse(input[2]);
                int row2 = int.Parse(input[3]);
                int col2 = int.Parse(input[4]);

                if (command.ToLower() != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (row1 < 0 || row2 < 0 || col1 < 0 || col2 < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (row1 > matrix.GetLength(0)-1 || row2 > matrix.GetLength(0) - 1 || col1 > matrix.GetLength(1) - 1 || col2 > matrix.GetLength(1) - 1)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string savedValue = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = savedValue;

                PrintMatrix(matrix);
            }

            
        }
        static void PrintMatrix(string[,] matrix)
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
    }
}
