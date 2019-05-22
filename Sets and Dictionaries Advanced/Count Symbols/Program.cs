using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var occurences = new SortedDictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (!occurences.ContainsKey(symbol))
                {
                    occurences.Add(symbol, 0);
                }
                occurences[symbol]++;
            }
            foreach (var symbol in occurences)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
