using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Word_Count_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWordsFilePath = "words.txt";
            string textFilePath = "text.txt";
            string actualResultPath = "actualResult.txt";
            string expectedResultPath = "expectedResult.txt";
            var expression = new Regex(@"\w+");

            Dictionary<string,int> keyWords = File.ReadAllLines(keyWordsFilePath).ToDictionary(x => x,x => 0);
            string text = File.ReadAllText(textFilePath);

            var matches = expression.Matches(text);

            foreach (Match match in matches)
            {
                if (keyWords.ContainsKey(match.Value.ToLower()))
                {
                    keyWords[match.Value.ToLower()]++;
                }
            }
            string[] result = new string[keyWords.Count];
            int counter = 0;
            foreach (var item in keyWords)
            {
                result[counter] = $"{item.Key} - {item.Value}";
                counter++;
            }
            File.WriteAllLines(actualResultPath, result);
        }
    }
}
