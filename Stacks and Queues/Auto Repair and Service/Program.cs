using System;
using System.Collections.Generic;

namespace Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>(Console.ReadLine().Split());
            var serviced = new Stack<string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('-');
                if (input[0] == "End")
                {
                    break;
                }

                if (input[0] == "Service" && queue.Count > 0)
                {
                    Console.WriteLine($"Vehicle {queue.Peek()} got served.");
                    serviced.Push(queue.Dequeue());
                }
                else if (input[0] == "CarInfo")
                {
                    if (queue.Contains(input[1]))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (input[0] == "History")
                {
                    Console.WriteLine(string.Join(", ", serviced));
                }
            }

            if (queue.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queue)}");
            }

            if (serviced.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", serviced)}");
            }
        }
    }
}
