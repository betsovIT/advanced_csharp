using System;
using System.Collections.Generic;
using System.Linq;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimm = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] lair = new char[dimm[0], dimm[1]];

            int playerRow = -1;
            int playerColl = -1;
            List<int[]> bunnies = new List<int[]>();

            //Filling the matrix and extracting the coordinates of the player and bunnies
            for (int i = 0; i < lair.GetLength(0); i++)
            {
                string tokens = Console.ReadLine();
                for (int j = 0; j < lair.GetLength(1); j++)
                {
                    lair[i, j] = tokens[j];
                    if (tokens[j] == 'P')
                    {
                        playerRow = i;
                        playerColl = j;
                    }
                    else if (lair[i, j] == 'B')
                    {
                        bunnies.Add(new int[] { i, j });
                    }
                }
            }

            string commands = Console.ReadLine();
            bool hasWon = false;
            bool hasLost = false;

            for (int i = 0; i < commands.Length; i++)
            {
                char command = commands[i];

                //Deals if the movement of the player and the possible encounters with a bunny or the border of the field
                if (command == 'L')
                {
                    if (!AreValidCoordinates(playerRow, playerColl - 1, lair))
                    {
                        lair[playerRow, playerColl] = '.';
                        hasWon = true;
                    }
                    else
                    {
                        if (lair[playerRow, playerColl - 1] == 'B')
                        {
                            lair[playerRow, playerColl] = '.';
                            playerColl--;
                            hasLost = true;
                        }
                        else
                        {
                            lair[playerRow, playerColl - 1] = 'P';
                            lair[playerRow, playerColl] = '.';
                            playerColl--;
                        }
                    }
                }
                else if (command == 'U')
                {
                    if (!AreValidCoordinates(playerRow - 1, playerColl, lair))
                    {
                        lair[playerRow, playerColl] = '.';
                        hasWon = true;
                    }
                    else
                    {
                        if (lair[playerRow - 1, playerColl] == 'B')
                        {
                            lair[playerRow, playerColl] = '.';
                            playerRow--;
                            hasLost = true;
                        }
                        else
                        {
                            lair[playerRow - 1, playerColl] = 'P';
                            lair[playerRow, playerColl] = '.';
                            playerRow--;
                        }
                    }
                }
                else if (command == 'R')
                {
                    if (!AreValidCoordinates(playerRow, playerColl + 1, lair))
                    {
                        lair[playerRow, playerColl] = '.';
                        hasWon = true;
                    }
                    else
                    {
                        if (lair[playerRow, playerColl + 1] == 'B')
                        {
                            lair[playerRow, playerColl] = '.';
                            playerColl++;
                            hasLost = true;
                        }
                        else
                        {
                            lair[playerRow, playerColl + 1] = 'P';
                            lair[playerRow, playerColl] = '.';
                            playerColl++;
                        }
                    }
                }
                else if (command == 'D')
                {
                    if (!AreValidCoordinates(playerRow + 1, playerColl, lair))
                    {
                        lair[playerRow, playerColl] = '.';
                        hasWon = true;
                    }
                    else
                    {
                        if (lair[playerRow + 1, playerColl] == 'B')
                        {
                            lair[playerRow, playerColl] = '.';
                            playerRow++;
                            hasLost = true;
                        }
                        else
                        {
                            lair[playerRow + 1, playerColl] = 'P';
                            lair[playerRow, playerColl] = '.';
                            playerRow++;
                        }
                    }
                }

                //Models the spread of bunnies
                var copyOFBunnies = new List<int[]>(bunnies);
                foreach (int[] coordinatePair in copyOFBunnies)
                {
                    int bunnieRow = coordinatePair[0];
                    int bunnieColl = coordinatePair[1];

                    if (AreValidCoordinates(bunnieRow, bunnieColl - 1, lair))
                    {
                        if (lair[bunnieRow, bunnieColl - 1] == '.')
                        {
                            lair[bunnieRow, bunnieColl - 1] = 'B';
                            bunnies.Add(new int[] { bunnieRow, bunnieColl - 1 });
                        }
                    }

                    if (AreValidCoordinates(bunnieRow - 1, bunnieColl, lair))
                    {
                        if (lair[bunnieRow - 1, bunnieColl] == '.')
                        {
                            lair[bunnieRow - 1, bunnieColl] = 'B';
                            bunnies.Add(new int[] { bunnieRow - 1, bunnieColl });
                        }
                    }

                    if (AreValidCoordinates(bunnieRow, bunnieColl + 1, lair))
                    {
                        if (lair[bunnieRow, bunnieColl + 1] == '.')
                        {
                            lair[bunnieRow, bunnieColl + 1] = 'B';
                            bunnies.Add(new int[] { bunnieRow, bunnieColl + 1 });
                        }
                    }

                    if (AreValidCoordinates(bunnieRow + 1, bunnieColl, lair))
                    {
                        if (lair[bunnieRow + 1, bunnieColl] == '.')
                        {
                            lair[bunnieRow + 1, bunnieColl] = 'B';
                            bunnies.Add(new int[] { bunnieRow + 1, bunnieColl });
                        }
                    }
                }
                if (hasWon)
                {
                    PrintMatrix(lair);
                    Console.WriteLine($"won: {playerRow} {playerColl}");
                    break;
                }
                if (hasLost)
                {
                    PrintMatrix(lair);
                    Console.WriteLine($"dead: {playerRow} {playerColl}");
                    break;
                }
                if (lair[playerRow, playerColl] == 'B')
                {
                    PrintMatrix(lair);
                    Console.WriteLine($"dead: {playerRow} {playerColl}");
                    break;
                }

            }
        }
        static void PrintMatrix(char[,] matrix)
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
        static bool AreValidCoordinates(int row, int coll, char[,] matrix)
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
