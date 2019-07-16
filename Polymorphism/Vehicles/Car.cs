using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : IVehicle
    {
        const double AdditionalAirConditionFuel = 0.9;

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Car(double fuel, double fuelConsumption)
        {
            FuelQuantity = fuel;
            FuelConsumption = fuelConsumption;
        }

        public void Drive(double distance)
        {
            if (FuelQuantity >= (FuelConsumption+AdditionalAirConditionFuel) * distance)
            {
                FuelQuantity -= (FuelConsumption + AdditionalAirConditionFuel) * distance;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double litters)
        {
            FuelQuantity += litters;
        }
    }
}
