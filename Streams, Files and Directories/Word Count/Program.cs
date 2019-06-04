using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";
            string keyWordsFile = "words.txt";
            string textToSearchFile = "text.txt";
            string keyWordsPath = Path.Combine(path, keyWordsFile);
            string textToSearchPath = Path.Combine(path, textToSearchFile);
            var expression = new Regex(@"\w+");

            using (var reader = new StreamReader(keyWordsPath))
            {
                Dictionary<string,int> words = reader
                    .ReadLine()
                    .Split()
                    .ToDictionary(x => x,x => 0);

                using (var secondReader = new StreamReader(textToSearchPath))
                {
                    var matches = expression.Matches(secondReader.ReadToEnd());

                    foreach (Match match in matches)
                    {
                        if (words.ContainsKey(match.Value.ToLower()))
                        {
                            words[match.Value.ToLower()]++;
                        }
                    }

                    foreach (var item in words.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"{item.Key}-{item.Value}");
                    }
                }
            }
        }
    }
}
