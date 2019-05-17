using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandLines = int.Parse(Console.ReadLine());

            var pumps = new Queue<int>();

            int tank = 0;
            int startIndex = 0;

            for (int i = 0; i < commandLines; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(nums[0] - nums[1]);
            }

            while (true)
            {
                bool returnToStart = false;
                if (pumps.Peek() < 0)
                {
                    pumps.Enqueue(pumps.Dequeue());
                    startIndex++;
                }
                else
                {
                    int[] copy = new int[pumps.Count];
                    pumps.CopyTo(copy, 0);

                    for (int i = 0; i < commandLines; i++)
                    {
                        tank += copy[i];
                        if (tank < 0)
                        {
                            tank = 0;
                            pumps.Enqueue(pumps.Dequeue());
                            startIndex++;
                            returnToStart = true;
                            break;
                        }
                    }

                    if (returnToStart)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(startIndex);
        }
    }
}
