using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>(Console.ReadLine().Split());
            int num = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 0; i < num-1; i++)
                {
                    string player = queue.Dequeue();
                    queue.Enqueue(player);
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
