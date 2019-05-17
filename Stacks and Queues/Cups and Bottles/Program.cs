using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int bottle = bottles.Pop();
                int cup = cups.Peek();

                while (cup > 0)
                {
                    if (cup - bottle <= 0)
                    {
                        cups.Dequeue();
                        wastedWater += bottle - cup;
                        break;
                    }
                    else if (cup - bottle > 0)
                    {
                        cup -= bottle;
                        bottle = bottles.Pop();                        
                    }
                }

                if (cup <= 0)
                {
                    cups.Dequeue();
                }
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(' ', cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
