using System;
using System.Collections.Generic;
using System.Linq;

namespace TheGarden2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int carrots = 0;
            int potatoes = 0;
            int lettuce = 0;
            int harmedvegies = 0;

            char[][] garden = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                char[] vegetables = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
                garden[i] = vegetables;
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End of Harvest")
                {
                    break;
                }

                string[] commandLine = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                if (commandLine[0] == "Harvest")
                {
                    int row = int.Parse(commandLine[1]);
                    int col = int.Parse(commandLine[2]);

                    if (AreValidCoordinates(row, col, garden))
                    {
                        if (garden[row][col] == 'P')
                        {
                            potatoes++;
                            garden[row][col] = ' ';
                        }
                        else if (garden[row][col] == 'C')
                        {
                            carrots++;
                            garden[row][col] = ' ';
                        }
                        else if (garden[row][col] == 'L')
                        {
                            lettuce++;
                            garden[row][col] = ' ';
                        }
                    }
                }
                else if (commandLine[0] == "Mole")
                {
                    int row = int.Parse(commandLine[1]);
                    int col = int.Parse(commandLine[2]);

                    if (commandLine[3] == "up")
                    {
                        for (int i = row; i >= 0; i -= 2)
                        {
                            if (AreValidCoordinates(i, col, garden))
                            {
                                if (garden[i][col] != ' ')
                                {
                                    garden[i][col] = ' ';
                                    harmedvegies++;
                                }
                            }
                        }
                    }
                    else if (commandLine[3] == "right")
                    {
                        for (int i = col; i < garden[row].Length; i += 2)
                        {
                            if (AreValidCoordinates(row, i, garden))
                            {
                                if (garden[row][i] != ' ')
                                {
                                    garden[row][i] = ' ';
                                    harmedvegies++;
                                }
                            }
                        }
                    }
                    else if (commandLine[3] == "down")
                    {
                        for (int i = row; i < garden.Length; i += 2)
                        {
                            if (AreValidCoordinates(i, col, garden))
                            {
                                if (garden[i][col] != ' ')
                                {
                                    garden[i][col] = ' ';
                                    harmedvegies++;
                                }
                            }
                        }
                    }
                    else if (commandLine[3] == "left")
                    {
                        for (int i = col; i >= 0; i -= 2)
                        {
                            if (AreValidCoordinates(row, i, garden))
                            {
                                if (garden[row][i] != ' ')
                                {
                                    garden[row][i] = ' ';
                                    harmedvegies++;
                                }
                            }
                        }
                    }

                }
            }

            PrintGarden(garden);

            Console.WriteLine($"Carrots: {carrots}");
            Console.WriteLine($"Potatoes: {potatoes}");
            Console.WriteLine($"Lettuce: {lettuce}");
            Console.WriteLine($"Harmed vegetables: {harmedvegies}");

        }

        public static bool AreValidCoordinates(int row, int col, char[][] field)
        {
            if (row < 0 || row >= field.Length)
            {
                return false;
            }

            if (col < 0 || col >= field[row].Length)
            {
                return false;
            }

            return true;
        }

        public static void PrintGarden(char[][] field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                Console.WriteLine(string.Join(' ', field[i]));
            }
        }
    }
}
