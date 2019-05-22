using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string,int>>();
            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var pieceOfClothing in clothes)
                {
                    if (!wardrobe[color].ContainsKey(pieceOfClothing))
                    {
                        wardrobe[color].Add(pieceOfClothing, 0);
                    }
                    wardrobe[color][pieceOfClothing]++;
                }
            }

            string toFind = Console.ReadLine();
            string colorToFind = toFind.Split()[0];
            string clothToFind = toFind.Split()[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");
                    if (color.Key == colorToFind && item.Key == clothToFind)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
