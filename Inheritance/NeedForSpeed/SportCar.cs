using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class SportCar : Car
    {
        public double DefaultFuelConsumption
        {
            get
            {
                return defaultFuelConsumption = 10;
            }
            set
            {
                defaultFuelConsumption = value;
            }
        }
    }
}
