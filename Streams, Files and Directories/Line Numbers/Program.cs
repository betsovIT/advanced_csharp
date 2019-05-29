using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";
            string fileNameInput = "Input.txt";
            string fileNameOutput = "Output.txt";
            string filePathInput = Path.Combine(path, fileNameInput);
            string filePathOutput = Path.Combine(path, fileNameOutput);
            int counter = 1;

            using (var reader = new StreamReader(filePathInput))
            {
                using (var writer = new StreamWriter(filePathOutput))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {                        
                        writer.WriteLine($"{counter}. " + line);
                        counter++;
                        line = reader.ReadLine();
                    }
                    
                }
            }
        }
    }
}
