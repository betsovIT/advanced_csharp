using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        private const int minSpeedHorsePower = 50;
        private const int maxSpeedHorsePower = 69;
        private const double speedCubicCentimeters = 125;

        public SpeedMotorcycle(string model, int horsePower)
            : base(model, speedCubicCentimeters)
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
                if (value < minSpeedHorsePower || value > maxSpeedHorsePower)
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
