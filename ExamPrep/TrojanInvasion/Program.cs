using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            var plates = new List<int>(Console.ReadLine().Split().Select(int.Parse));
            var warriors = new Stack<int>();

            for (int i = 0; i < waves; i++)
            {
                int[] newWarriors = Console.ReadLine().Split().Select(int.Parse).ToArray();
                foreach (var warrior in newWarriors)
                {
                    warriors.Push(warrior);
                }

                if ((i + 1) % 3 == 0)
                {
                    plates.Add(int.Parse(Console.ReadLine()));
                }

                while (warriors.Count > 0 && plates.Count > 0)
                {
                    if (plates[0] - warriors.Peek() > 0)
                    {
                        plates[0] -= warriors.Pop();
                    }
                    else if (plates[0] - warriors.Peek() == 0)
                    {
                        plates.RemoveAt(0);
                        warriors.Pop();
                    }
                    else if (plates[0] - warriors.Peek() < 0)
                    {
                        warriors.Push(warriors.Pop() - plates[0]);
                        plates.RemoveAt(0);                        
                    }

                }

                if (plates.Count == 0)
                {
                    break;
                }
            }

            if (plates.Count == 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ", warriors)}");
            }
            else if (warriors.Count == 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
    }
}
