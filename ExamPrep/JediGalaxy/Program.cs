using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace JediGalaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] galaxySize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] galaxy = new int[galaxySize[0], galaxySize[1]];
            int counter = 0;

            for (int i = 0; i < galaxy.GetLength(0); i++)
            {
                for (int j = 0; j < galaxy.GetLength(1); j++)
                {
                    galaxy[i, j] = counter++;
                }
            }

            BigInteger ivoSum = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Let the Force be with you")
                {
                    break;
                }

                int ivoRow = int.Parse(input.Split()[0]);
                int ivoCol = int.Parse(input.Split()[1]);

                string evilInput = Console.ReadLine();
                int evilRow = int.Parse(evilInput.Split()[0]);
                int evilCol = int.Parse(evilInput.Split()[1]);

                while (evilRow >= 0 && evilCol >= 0)
                {
                    if (AreValidCoordinates(evilCol, evilRow, galaxy))
                    {
                        galaxy[evilRow, evilCol] = 0;
                    }
                    evilRow -= 1;
                    evilCol -= 1;
                }

                while (ivoRow >= 0 && ivoCol < galaxy.GetLength(1))
                {
                    if (AreValidCoordinates(ivoCol, ivoRow, galaxy))
                    {
                        ivoSum += galaxy[ivoRow, ivoCol];
                    }
                    ivoRow -= 1;
                    ivoCol += 1;
                }
            }
            Console.WriteLine(ivoSum);
        }

        public static bool AreValidCoordinates(int row, int col, int[,] field)
        {
            if (row < 0 || row >= field.GetLength(0))
            {
                return false;
            }

            if (col < 0 || col >= field.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}
