using System;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Truck truck = new Truck();
            Bus bus = new Bus();

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Car")
                {                    
                    car.FuelConsumption = double.Parse(input[2]);
                    car.TankCapacity = int.Parse(input[3]);
                    car.FuelQuantity = double.Parse(input[1]);
                }
                else if (input[0] == "Truck")
                {                    
                    truck.FuelConsumption = double.Parse(input[2]);
                    truck.TankCapacity = int.Parse(input[3]);
                    truck.FuelQuantity = double.Parse(input[1]);
                }
                else if (input[0] == "Bus")
                {
                    bus.FuelConsumption = double.Parse(input[2]);
                    bus.TankCapacity = int.Parse(input[3]);
                    bus.FuelQuantity = double.Parse(input[1]);
                }
            }

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
                else if (vehicle == "Bus")
                {
                    if (command == "Drive")
                    {
                        bus.Drive(parameter);
                    }
                    else if (command == "DriveEmpty")
                    {
                        bus.Drive(parameter, true);
                    }
                    else if (command == "Refuel")
                    {
                        bus.Refuel(parameter);
                    }

                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}

