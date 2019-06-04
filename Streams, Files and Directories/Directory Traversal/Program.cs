using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();
            var files = Directory.GetFiles(path);
            string output = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"output.txt");

            var filesDictionary = new Dictionary<string, Dictionary<string,long>>();

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                long fileLength = fileInfo.Length;
                string fileExtension = fileInfo.Extension;
                string fileName = fileInfo.Name;

                if (!filesDictionary.ContainsKey(fileExtension))
                {
                    filesDictionary.Add(fileExtension, new Dictionary<string, long>());
                }

                if (!filesDictionary[fileExtension].ContainsKey(fileName))
                {
                    filesDictionary[fileExtension].Add(fileName, fileLength);
                }
            }

            using (var writer = new StreamWriter(output))
            {
                foreach (var extension in filesDictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(extension.Key);
                    foreach (var file in extension.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value}kb");
                    }
                }

            }
        }
    }
}
