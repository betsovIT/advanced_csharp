using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    interface IVehicle
    {
        double FuelQuantity { get; set; }
        double FuelConsumption { get; set; }
        int TankCapacity { get; set; }

        void Drive(double distance);
        void Refuel(double litters);
    }
}
