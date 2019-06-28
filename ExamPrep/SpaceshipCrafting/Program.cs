using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            var createdMaterials = new List<string>();
            var masterTable = new Dictionary<int, string>()
            {
                {25, "Glass" },
                {50, "Aluminium" },
                {75, "Lithium"},
                {100, "Carbon fiber"}
            };

            var chemicals = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var items = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            while (chemicals.Count > 0 && items.Count > 0)
            {
                if (chemicals.Peek() + items.Peek() == 25)
                {
                    createdMaterials.Add(masterTable[25]);
                    chemicals.Dequeue();
                    items.Pop();
                }
                else if (chemicals.Peek() + items.Peek() == 50)
                {
                    createdMaterials.Add(masterTable[50]);
                    chemicals.Dequeue();
                    items.Pop();
                }
                else if (chemicals.Peek() + items.Peek() == 75)
                {
                    createdMaterials.Add(masterTable[75]);
                    chemicals.Dequeue();
                    items.Pop();
                }
                else if (chemicals.Peek() + items.Peek() == 100)
                {
                    createdMaterials.Add(masterTable[100]);
                    chemicals.Dequeue();
                    items.Pop();
                }
                else
                {
                    chemicals.Dequeue();
                    int temp = items.Pop() + 3;
                    items.Push(temp);
                }
            }

            if (createdMaterials.Contains("Glass")
                && createdMaterials.Contains("Aluminium")
                    && createdMaterials.Contains("Lithium")
                        && createdMaterials.Contains("Carbon fiber"))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (chemicals.Count==0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",chemicals)}");
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
            }

            Console.WriteLine($"Aluminium: {createdMaterials.Where(n => n == "Aluminium").Count()}");
            Console.WriteLine($"Carbon fiber: {createdMaterials.Where(n => n == "Carbon fiber").Count()}");
            Console.WriteLine($"Glass: {createdMaterials.Where(n => n == "Glass").Count()}");
            Console.WriteLine($"Lithium: {createdMaterials.Where(n => n == "Lithium").Count()}");
        }
    }
}
