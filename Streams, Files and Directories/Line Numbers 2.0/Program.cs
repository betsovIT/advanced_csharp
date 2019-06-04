using System;
using System.Collections.Generic;
using System.IO;

namespace Line_Numbers_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "text.txt";
            string outputFile = "output.txt";
            int counter = 1;

            string[] lines = File.ReadAllLines(inputFile);
            List<string> newLines = new List<string>();
            foreach (var line in lines)
            {
                int symbolCounter = 0;
                int letterCounter = 0;
                for (int i = 0; i < line.Length; i++)
                {
                    if (Char.IsLetter(line[i]))
                    {
                        letterCounter++;
                    }
                    else if(Char.IsPunctuation(line[i]))
                    {
                        symbolCounter++;
                    }
                }
                newLines.Add($"Line {counter}: {line} ({letterCounter})({symbolCounter})");
            }
            File.WriteAllLines(outputFile, newLines);
        }
    }
}
