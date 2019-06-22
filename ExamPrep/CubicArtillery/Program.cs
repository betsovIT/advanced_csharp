using System;
using System.Collections.Generic;
using System.Linq;

namespace CubicArtillery
{
    class Program
    {
        static void Main(string[] args)
        {
            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Bunker Revision")
                {
                    break;
                }

                string[] tokens = input.Split();

                for (int i = 0; i < tokens.Length; i++)
                {
                    if (Char.IsLetter(tokens[i][0]))
                    {
                        bunkers.Enqueue(tokens[i]);
                    }
                    else
                    {
                        int weapon = int.Parse(tokens[i]);
                        if (weapon <= capacity)
                        {
                            weapons.Enqueue(weapon);
                        }
                    }
                }




            }
        }
    }
}
