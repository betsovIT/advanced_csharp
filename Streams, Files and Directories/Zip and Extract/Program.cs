using System;
using System.IO;
using System.IO.Compression;

namespace Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = Console.ReadLine();
            string zipPath = "picture.zip";
            ZipFile.CreateFromDirectory(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }
    }
}
