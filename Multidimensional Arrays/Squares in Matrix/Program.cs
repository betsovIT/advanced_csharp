using System;
using System.Linq;

namespace Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimmensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[dimmensions[0], dimmensions[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] tokens = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tokens[j];
                }
            }

            int charsMatchingInASquare = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    char charToMatch = matrix[i, j];
                    if (matrix[i, j + 1] == charToMatch 
                            && matrix[i + 1, j] == charToMatch 
                                && matrix[i + 1, j + 1] == charToMatch)
                    {
                        charsMatchingInASquare++;
                    }
                }
            }
            Console.WriteLine(charsMatchingInASquare);
        }
    }
}
