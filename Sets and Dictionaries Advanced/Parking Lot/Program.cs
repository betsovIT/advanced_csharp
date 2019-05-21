using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new HashSet<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string direction = input.Split(',', StringSplitOptions.RemoveEmptyEntries)[0];
                string car = input.Split(',', StringSplitOptions.RemoveEmptyEntries)[1];

                if (direction == "IN")
                {
                    parking.Add(car);
                }
                else if (direction == "OUT")
                {
                    parking.Remove(car);
                }
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            
        }
    }
}
