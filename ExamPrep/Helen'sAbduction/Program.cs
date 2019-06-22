using System;

namespace Helen_sAbduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            string firstRow = Console.ReadLine();
            char[,] field = new char[rows, firstRow.Length];

            int parisRow = -1;
            int parisCol = -1;

            int helenRow = -1;
            int helenCol = -1;

            for (int i = 0; i < firstRow.Length; i++)
            {
                field[0, i] = firstRow[i];
            }

            for (int i = 1; i < field.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = input[j];                
                }
            }
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i,j] == 'P')
                    {
                        parisRow = i;
                        parisCol = j;
                    }
                    else if (field[i, j] == 'H')
                    {
                        helenRow = i;
                        helenCol = j;
                    }
                }
            }

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split();
                string command = commandLine[0];
                int spawnRow = int.Parse(commandLine[1]);
                int spawnCol = int.Parse(commandLine[2]);

                field[spawnRow, spawnCol] = 'S';

                if (command == "up")
                {
                    if (AreValidCoordinates(parisRow - 1, parisCol, field))
                    {
                        field[parisRow, parisCol] = '-';
                        parisRow -= 1;
                        energy -= 1;
                    }
                    else
                    {
                        energy -= 1;
                    }                    
                }
                else if (command == "right")
                {
                    if (AreValidCoordinates(parisRow, parisCol + 1, field))
                    {
                        field[parisRow, parisCol] = '-';
                        parisCol += 1;
                        energy -= 1;
                    }
                    else
                    {
                        energy -= 1;
                    }
                }
                else if (command == "down")
                {
                    if (AreValidCoordinates(parisRow + 1, parisCol, field))
                    {
                        field[parisRow, parisCol] = '-';
                        parisRow += 1;
                        energy -= 1;
                    }
                    else
                    {
                        energy -= 1;
                    }
                }
                else if (command == "left")
                {
                    if (AreValidCoordinates(parisRow, parisCol - 1, field))
                    {
                        field[parisRow, parisCol] = '-';
                        parisCol -= 1;
                        energy -= 1;
                    }
                    else
                    {
                        energy -= 1;
                    }
                }

                if (field[parisRow,parisCol] == 'H')
                {
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
                    field[parisRow, parisCol] = '-';
                    break;
                }
                else if (field[parisRow, parisCol] == 'S')
                {
                    energy -= 2;
                    if (energy <= 0)
                    {
                        field[parisRow, parisCol] = 'X';
                        Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                        break;
                    }
                    else
                    {
                        field[parisRow, parisCol] = 'P';
                    }
                }
                else
                {
                    field[parisRow, parisCol] = 'P';
                }

                if (energy <= 0)
                {
                    field[parisRow, parisCol] = 'X';
                    Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                    break;
                }

            }
            PrintField(field);
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
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
