using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int window = int.Parse(Console.ReadLine());

            var cars = new Queue<string>();

            int passedCars = 0;
            bool crash = false;

            while (true)
            {
                string input = Console.ReadLine();
                int counter = greenLight;
                bool breakCycle = false;

                if (input == "END")
                {
                    break;
                }

                else if (input == "green")
                {
                    while (counter > 0 && cars.Count > 0)
                    {
                        string car = cars.Dequeue();
                        counter -= car.Length;

                        if (counter < 0)
                        {
                            if (Math.Abs(counter) <= window)
                            {
                                passedCars++;
                                continue;
                            }
                            else
                            {
                                crash = true;
                                breakCycle = true;
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[car.Length+counter+window]}.");
                                break;
                            }
                        }                        
                        passedCars++;
                    }
                    if (breakCycle)
                    {
                        break;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }

            if (!crash)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }

        }
    }
}
