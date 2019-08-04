using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const double standartCubics = 450;
        private const int minHP = 70;
        private const int maxHP = 100;

        public PowerMotorcycle(string model, int horsePower)
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
