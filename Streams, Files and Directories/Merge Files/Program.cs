using System;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";
            string firstFile = "FileOne.txt";
            string secondFile = "FileTwo.txt";
            string outputFile = "Output.txt";
            string firstFilePath = Path.Combine(path, firstFile);
            string secondFilePath = Path.Combine(path, secondFile);
            string outputFilePath = Path.Combine(path, outputFile);

            using (var firstReader = new StreamReader(firstFilePath))
            {
                using (var secondReader = new StreamReader(secondFilePath))
                {
                    bool readFromFirst = true;
                    bool readFromSecond = true;
                    string lineOne = firstReader.ReadLine();
                    string lineTwo = secondReader.ReadLine();

                    using (var writer = new StreamWriter(outputFilePath))
                    {
                        while (readFromFirst && readFromSecond)
                        {
                            writer.WriteLine(lineOne);
                            writer.WriteLine(lineTwo);

                            lineOne = firstReader.ReadLine();
                            lineTwo = secondReader.ReadLine();

                            if (lineOne == null)
                            {
                                readFromFirst = false;
                            }
                            if (lineTwo == null)
                            {
                                readFromSecond = false;
                            }
                        }
                    }                        
                }
            }
        }
    }
}
