using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int passingCars = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                if (input == "green")
                {
                    for (int i = 0; i < passingCars; i++)
                    {
                        if (queue.Count>=1)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
