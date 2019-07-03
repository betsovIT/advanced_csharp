using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class Car : Vehicle
    {
        public double DefaultFuelConsumption
        {
            get
            {
                return defaultFuelConsumption = 3;
            }
            set
            {
                defaultFuelConsumption = value;
            }
        }
    }
}
