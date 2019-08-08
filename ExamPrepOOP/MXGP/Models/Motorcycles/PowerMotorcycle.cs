using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const int minPowerHorsePower = 70;
        private const int maxPowerHorsePower = 100;
        private const double powerCubicCentimeters = 450;
        public PowerMotorcycle(string model, int horsePower)
            : base(model, powerCubicCentimeters)
        {
            HorsePower = horsePower;
        }

        public override int HorsePower
        {
            get
            {
                return base.HorsePower;
            }
            protected set
            {
                if (value < minPowerHorsePower || value > maxPowerHorsePower)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower, value));
                }
                else
                {
                    base.HorsePower = value;
                }
            }
        }
    }
}
