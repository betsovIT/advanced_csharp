using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    interface IVehicle
    {
        double FuelQuantity { get; set; }
        double FuelConsumption { get; set; }

        void Drive(double distance);
        void Refuel(double litters);
    }
}
