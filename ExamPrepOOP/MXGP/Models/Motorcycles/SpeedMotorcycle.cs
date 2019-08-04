using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        private const double standartCubics = 125;
        private const int minHP = 50;
        private const int maxHP = 69;

        public SpeedMotorcycle(string model, int horsePower) 
            : base(model, horsePower, standartCubics)
        {
            this.HorsePower = horsePower;
        }

        public override int HorsePower
        {
            get
            {
                return base.HorsePower;
            }
            protected set
            {
                if (value < minHP || value > maxHP)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower,value));
                }
                else
                {
                    base.HorsePower = value;
                }
            }
        }
    }
}
