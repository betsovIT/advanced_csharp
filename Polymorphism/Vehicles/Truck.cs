using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : IVehicle
    {
        const double AdditionalAirConditionFuel = 1.6;

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Truck(double fuel, double fuelConsumption)
        {
            FuelQuantity = fuel;
            FuelConsumption = fuelConsumption;
        }

        public void Drive(double distance)
        {
            if (FuelQuantity >= (FuelConsumption + AdditionalAirConditionFuel) * distance)
            {
                FuelQuantity -= (FuelConsumption + AdditionalAirConditionFuel) * distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double litters)
        {
            FuelQuantity += litters * 0.95;
        }
    }
}
