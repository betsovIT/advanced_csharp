using System;
using System.Collections.Generic;
using System.Linq;

namespace TheGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var strs = new List<string[]>();

            int carrots = 0;
            int potatoes = 0;
            int lettuce = 0;
            int harmedVegetables = 0;

            for (int i = 0; i < lines; i++)
            {
                strs.Add(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
            }

            int maxLengthOfLine = strs.Max(n => n.Length);
            char[,] field = new char[lines, maxLengthOfLine];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                string[] input = strs[i];
                for (int j = 0; j < input.Length; j++)
                {
                    field[i, j] = input[j][0];
                }
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == '\0')
                    {
                        field[i, j] = ' ';
                    }
                }
            }

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split();
                if (commandLine[0] == "End")
                {
                    break;
                }
                string command = commandLine[0];

                if (command == "Harvest")
                {
                    int row = int.Parse(commandLine[1]);
                    int col = int.Parse(commandLine[2]);

                    if (AreValidCoordinates(row, col, field))
                    {
                        switch (field[row, col])
                        {
                            case 'C': carrots++; break;
                            case 'P': potatoes++; break;
                            case 'L': lettuce++; break;
                            default:
                                break;
                        }
                        field[row, col] = ' ';
                    }
                }
                else if (command == "Mole")
                {
                    string direction = commandLine[3];

                    int row = int.Parse(commandLine[1]);
                    int col = int.Parse(commandLine[2]);

                    if (AreValidCoordinates(row, col, field))
                    {
                        if (direction == "right")
                        {
                            while (col < field.GetLength(1))
                            {
                                if (field[row,col] != ' ')
                                {
                                    harmedVegetables++;
                                }
                                field[row, col] = ' ';
                                col += 2;
                            }
                        }

                        if (direction == "left")
                        {
                            while (col >= 0)
                            {
                                if (field[row, col] != ' ')
                                {
                                    harmedVegetables++;
                                }
                                field[row, col] = ' ';
                                col -= 2;
                            }
                        }

                        if (direction == "up")
                        {
                            while (row >= 0)
                            {
                                if (field[row, col] != ' ')
                                {
                                    harmedVegetables++;
                                }
                                field[row, col] = ' ';
                                row -= 2;
                            }
                        }

                        if (direction == "down")
                        {
                            while (col < field.GetLength(0))
                            {
                                if (field[row, col] != ' ')
                                {
                                    harmedVegetables++;
                                }
                                field[row, col] = ' ';
                                row += 2;
                            }
                        }
                    }
                }
            }

            PrintField(field);
            Console.WriteLine($"Carrots: {carrots}");
            Console.WriteLine($"Potatoes: {potatoes}");
            Console.WriteLine($"Lettuce: {lettuce}");
            Console.WriteLine($"Harmed vegetables: {harmedVegetables}");
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

        public static void PrintField(char[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write($"{field[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
