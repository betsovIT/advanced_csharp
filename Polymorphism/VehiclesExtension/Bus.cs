using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    class Bus
    {
        const double AdditionalAirConditionFuel = 1.4;

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

        public Bus()
        {

        }

        public Bus(double fuel, double fuelConsumption, int tankCapacity)
        {
            FuelQuantity = fuel;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public void Drive(double distance)
        {
            if (FuelQuantity >= (FuelConsumption + AdditionalAirConditionFuel) * distance)
            {
                FuelQuantity -= (FuelConsumption + AdditionalAirConditionFuel) * distance;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void Drive(double distance, bool isEmpty)
        {
            if (FuelQuantity >= FuelConsumption * distance)
            {
                FuelQuantity -= FuelConsumption * distance;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
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
