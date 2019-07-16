using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split();
            string[] truckInput = Console.ReadLine().Split();

            var car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]));
            var truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));

            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string vehicle = input[1];
                string command = input[0];
                double parameter = double.Parse(input[2]);

                if (vehicle == "Car")
                {
                    if (command == "Drive")
                    {
                        car.Drive(parameter);
                    }
                    else if (command == "Refuel")
                    {
                        car.Refuel(parameter);
                    }
                }
                else if (vehicle == "Truck")
                {
                    if (command == "Drive")
                    {
                        truck.Drive(parameter);
                    }
                    else if (command == "Refuel")
                    {
                        truck.Refuel(parameter);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}
