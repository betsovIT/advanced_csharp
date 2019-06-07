using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string,Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(model,car);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string model = input.Split()[1];
                double distance = double.Parse(input.Split()[2]);

                cars[model].Drive(distance);
            }
            foreach (var carEntry in cars)
            {
                Console.WriteLine($"{carEntry.Value.Model} {carEntry.Value.FuelAmount:F2} {carEntry.Value.TraveledDistance}");
            }
        }
    }
}
