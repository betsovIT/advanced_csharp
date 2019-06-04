using System;
using System.IO;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "copyMe.png";
            string outputFile = "result.jpg";

            using (var readFile = new FileStream(inputFile, FileMode.Open))
            {
                using (var writeFile = new FileStream(outputFile, FileMode.Create))
                {
                    byte[] buffer = new byte[2048];
                    while (readFile.Read(buffer, 0, buffer.Length) > 0)
                    {
                        writeFile.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
