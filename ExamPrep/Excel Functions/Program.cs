using System;
using System.Collections.Generic;
using System.Linq;

namespace Excel_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string[] header = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string[,] table = new string[lines - 1, header.Length];

            for (int i = 0; i < lines - 1; i++)
            {
                string[] row = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < header.Length; j++)
                {
                    table[i, j] = row[j];
                }
            }

            string[] commandLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            

            if (commandLine.Length == 2)
            {
                string command = commandLine[0];
                int col = Array.IndexOf(header, commandLine[1]);

                

                if (command == "hide")
                {
                    List<string> temp = new List<string>(header);
                    temp.Remove(commandLine[1]);
                    Console.WriteLine(string.Join(" | ", temp));

                    for (int i = 0; i < table.GetLength(0); i++)
                    {
                        List<string> toPrint = new List<string>();
                        for (int j = 0; j < table.GetLength(1); j++)
                        {
                            if (j != col)
                            {
                                toPrint.Add(table[i, j]);
                            }
                        }
                        Console.WriteLine(string.Join(" | ", toPrint));
                    }
                }
                else if (command == "sort")
                {
                    Console.WriteLine(string.Join(" | ", header));

                    string[] sorted = new string[lines - 1];

                    for (int i = 0; i < table.GetLength(0); i++)
                    {
                        sorted[i] = table[i, col];
                    }

                    sorted = sorted.OrderBy(n => n).ToArray();

                    for (int i = 0; i < sorted.Length; i++)
                    {
                        List<string> temp = new List<string>();
                        for (int j = 0; j < table.GetLength(0); j++)
                        {
                            if (table[j,col] == sorted[i])
                            {
                                for (int k = 0; k < table.GetLength(1); k++)
                                {
                                    temp.Add(table[j, k]);
                                }
                                Console.WriteLine(string.Join(" | ", temp));
                            }

                            
                        }


                    }
                }
            }
            else
            {
                int col = Array.IndexOf(header, commandLine[1]);
                string argument = commandLine[2];

                Console.WriteLine(string.Join(" | ", header));

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if (table[i, col] == argument)
                    {
                        List<string> temp = new List<string>();
                        for (int j = 0; j < table.GetLength(1); j++)
                        {
                            temp.Add(table[i, j]);
                        }
                        Console.WriteLine(string.Join(" | ", temp));
                    }
                }
            }
        }
    }
}
