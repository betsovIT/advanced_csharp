using System;
using System.IO;

namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFile = "text.txt";
            string outputFile = "output.txt";
            char[] symbols = new char[]
            {
                '-',',','.', '!', '?'
            };
            int counter = 0;

            using (var reader = new StreamReader(textFile))
            {
                using (var writer = new StreamWriter(outputFile))
                {
                    while (true)
                    {

                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        foreach (var symbol in symbols)
                        {
                            line = line.Replace(symbol, '@');
                        }
                        if (counter % 2 == 0)
                        {
                            writer.WriteLine(Reverse(line));
                        }
                    }
                }
                
            }
        }
        static string Reverse(string str)
        {
            string[] token = str.Split();
            Array.Reverse(token);
            return string.Join(' ', token);
        }
    }
}
