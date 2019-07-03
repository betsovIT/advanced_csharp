using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class RaceMotorcycle : Motorcycle
    {
        public double DefaultFuelConsumption
        {
            get
            {
                return defaultFuelConsumption = 8;
            }
            set
            {
                defaultFuelConsumption = value;
            }
        }
    }
}
