using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    class Car : IVehicle
    {
        const double AdditionalAirConditionFuel = 0.9;

        private double fuelQuantity;

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                if (value > TankCapacity || value < 0)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }
    
        public double FuelConsumption { get; set; }
        public int TankCapacity { get; set; }

        public Car()
        {

        }
        public Car(double fuel, double fuelConsumption, int tankCapacity)
        {
            FuelQuantity = fuel;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
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
            if (litters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (FuelQuantity + litters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {litters} fuel in the tank");
            }
            else
            {
                FuelQuantity += litters;
            }
        }
    }
}
