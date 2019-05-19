using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[,] field = new char[size, size];

            int coalCounter = 0;
            int collectedCoal = 0;

            int minerRow = -1;
            int minerColl = -1;

            //Constructing the field, counting the existing coals and finding the starting coordinates
            for (int i = 0; i < size; i++)
            {
                char[] tokens = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < size; j++)
                {
                    field[i, j] = tokens[j];
                    if (tokens[j] == 'c')
                    {
                        coalCounter++;
                    }
                    else if (tokens[j] == 's')
                    {
                        minerRow = i;
                        minerColl = j;
                    }
                }
            }

            //Executing the commands
            for (int i = 0; i < commands.Length; i++)
            {
                if (coalCounter == 0)
                {
                    Console.WriteLine($"You collected all coals!({minerRow}, {minerColl})");
                    return;
                }

                string command = commands[i];
                if (command == "left" && minerColl - 1 >= 0)
                {
                    minerColl -= 1;
                }
                else if (command == "right" && minerColl + 1 < size)
                {
                    minerColl += 1;
                }
                else if (command == "up" && minerRow - 1 >= 0)
                {
                    minerRow -= 1;
                }
                else if (command == "down" && minerRow + 1 < size)
                {
                    minerRow += 1;
                }

                if (field[minerRow,minerColl] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerColl})");
                    return;
                }
                else if (field[minerRow, minerColl] == 'c')
                {
                    collectedCoal++;
                    coalCounter--;
                    field[minerRow, minerColl] = '*';
                }
            }

            if (coalCounter == 0)
            {
                Console.WriteLine($"You collected all coals! ({minerRow}, {minerColl})");
            }
            else
            {
                Console.WriteLine($"{coalCounter} coals left. ({minerRow}, {minerColl})");
            }            
        }
        static void PrintMatrix(char[,] matrix)
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
