using System;
using System.Collections.Generic;

namespace SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int energy = 0;
            char[,] galaxy = new char[size, size];

            var blackHoles = new List<int>();

            int stephenRow = -1;
            int stephenCol = -1;

            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    galaxy[i, j] = input[j];

                    if (input[j] == 'S')
                    {
                        stephenRow = i;
                        stephenCol = j;
                    }
                    else if (input[j] == 'O')
                    {
                        blackHoles.Add(i);
                        blackHoles.Add(j);
                    }
                }
            }

            while (true)
            {
                if (energy >= 50)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    Console.WriteLine($"Star power collected: {energy}");
                    PrintGalaxy(galaxy);
                    break;
                }

                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (AreValidCoordinates(stephenRow - 1, stephenCol, galaxy))
                    {
                        galaxy[stephenRow, stephenCol] = '-';
                        stephenRow -= 1;
                        if (galaxy[stephenRow,stephenCol] == 'O')
                        {
                            galaxy[stephenRow, stephenCol] = '-';
                            if (blackHoles[0] == stephenRow && blackHoles[1] == stephenCol)
                            {
                                stephenRow = blackHoles[2];
                                stephenCol = blackHoles[3];
                                galaxy[stephenRow, stephenCol] = 'S';
                            }
                            else
                            {
                                stephenRow = blackHoles[0];
                                stephenCol = blackHoles[1];
                                galaxy[stephenRow, stephenCol] = 'S';
                            }
                        }
                        else if (char.IsDigit(galaxy[stephenRow, stephenCol]))
                        {
                            energy += int.Parse(galaxy[stephenRow, stephenCol].ToString());
                            galaxy[stephenRow, stephenCol] = 'S';
                        }
                    }
                    else
                    {
                        galaxy[stephenRow, stephenCol] = '-';
                        PrintFailure(energy, galaxy);
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (AreValidCoordinates(stephenRow, stephenCol + 1, galaxy))
                    {
                        galaxy[stephenRow, stephenCol] = '-';
                        stephenCol += 1;
                        if (galaxy[stephenRow, stephenCol] == 'O')
                        {
                            galaxy[stephenRow, stephenCol] = '-';
                            if (blackHoles[0] == stephenRow && blackHoles[1] == stephenCol)
                            {
                                stephenRow = blackHoles[2];
                                stephenCol = blackHoles[3];
                                galaxy[stephenRow, stephenCol] = 'S';
                            }
                            else
                            {
                                stephenRow = blackHoles[0];
                                stephenCol = blackHoles[1];
                                galaxy[stephenRow, stephenCol] = 'S';
                            }
                        }
                        else if (char.IsDigit(galaxy[stephenRow, stephenCol]))
                        {
                            energy += int.Parse(galaxy[stephenRow, stephenCol].ToString());
                            galaxy[stephenRow, stephenCol] = 'S';
                        }
                    }
                    else
                    {
                        galaxy[stephenRow, stephenCol] = '-';
                        PrintFailure(energy, galaxy);
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (AreValidCoordinates(stephenRow + 1, stephenCol, galaxy))
                    {
                        galaxy[stephenRow, stephenCol] = '-';
                        stephenRow += 1;
                        if (galaxy[stephenRow, stephenCol] == 'O')
                        {
                            galaxy[stephenRow, stephenCol] = '-';
                            if (blackHoles[0] == stephenRow && blackHoles[1] == stephenCol)
                            {
                                stephenRow = blackHoles[2];
                                stephenCol = blackHoles[3];
                                galaxy[stephenRow, stephenCol] = 'S';
                            }
                            else
                            {
                                stephenRow = blackHoles[0];
                                stephenCol = blackHoles[1];
                                galaxy[stephenRow, stephenCol] = 'S';
                            }
                        }
                        else if (char.IsDigit(galaxy[stephenRow, stephenCol]))
                        {
                            energy += int.Parse(galaxy[stephenRow, stephenCol].ToString());
                            galaxy[stephenRow, stephenCol] = 'S';
                        }
                    }
                    else
                    {
                        galaxy[stephenRow, stephenCol] = '-';
                        PrintFailure(energy, galaxy);
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (AreValidCoordinates(stephenRow, stephenCol - 1, galaxy))
                    {
                        galaxy[stephenRow, stephenCol] = '-';
                        stephenCol -= 1;
                        if (galaxy[stephenRow, stephenCol] == 'O')
                        {
                            galaxy[stephenRow, stephenCol] = '-';
                            if (blackHoles[0] == stephenRow && blackHoles[1] == stephenCol)
                            {
                                stephenRow = blackHoles[2];
                                stephenCol = blackHoles[3];
                                galaxy[stephenRow, stephenCol] = 'S';
                            }
                            else
                            {
                                stephenRow = blackHoles[0];
                                stephenCol = blackHoles[1];
                                galaxy[stephenRow, stephenCol] = 'S';
                            }
                        }
                        else if (char.IsDigit(galaxy[stephenRow, stephenCol]))
                        {
                            energy += int.Parse(galaxy[stephenRow, stephenCol].ToString());
                            galaxy[stephenRow, stephenCol] = 'S';
                        }
                    }
                    else
                    {
                        galaxy[stephenRow, stephenCol] = '-';
                        PrintFailure(energy, galaxy);
                        break;
                    }
                }

            }
        }
        public static bool AreValidCoordinates(int row, int col, char[,] field)
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

        public static void PrintGalaxy(char[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void PrintFailure(int energy, char[,] field)
        {
            Console.WriteLine("Bad news, the spaceship went to the void.");
            Console.WriteLine($"Star power collected: {energy}");
            PrintGalaxy(field);
        }

    }
}
