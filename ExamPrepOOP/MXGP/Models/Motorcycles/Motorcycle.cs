using MXGP.Models.Motorcycles.Contracts;
using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public abstract class Motorcycle : IMotorcycle
    {
        private string model;
        private int horsePower;
        private double cubicCentimeters;

        public Motorcycle(string model,int horsePower, double cubicCentimeters)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.cubicCentimeters = cubicCentimeters;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidModel,value,4));
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public virtual int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            protected set
            {
                this.horsePower = value;
            }
        }

        public double CubicCentimeters => this.cubicCentimeters;

        public double CalculateRacePoints(int laps)
        {
            return this.CubicCentimeters / HorsePower * laps;
        }
    }
}
