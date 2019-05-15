using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            var queue = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            int[] queueAsArray = new int[queue.Count];
            queue.CopyTo(queueAsArray, 0);
            Console.WriteLine(queueAsArray.Max());

            while (true)
            {
                if (queue.Count > 0)
                {
                    if (foodQuantity >= queue.Peek())
                    {
                        foodQuantity -= queue.Dequeue();
                    }
                    else
                    {
                        Console.Write("Orders left: ");
                        Console.WriteLine(string.Join(' ',queue));
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
                
            }
        }
    }
}
