using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var clients = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                if (input == "Paid")
                {
                    while (clients.Count > 0)
                    {
                        string client = clients.Dequeue();
                        Console.WriteLine(client);
                    }
                    continue;
                }

                clients.Enqueue(input);
            }

            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
