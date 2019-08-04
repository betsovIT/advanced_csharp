using MXGP.Models.Motorcycles.Contracts;
using MXGP.Models.Riders.Contracts;
using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Riders
{
    public class Rider : IRider
    {
        private string name;
        private int numberOfWins;
        private IMotorcycle motorcycle;

        public Rider(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName,value,5));
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public IMotorcycle Motorcycle
        {
            get
            {
                return this.motorcycle;
            }
            private set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(ExceptionMessages.MotorcycleInvalid);
                }
                else
                {
                    this.motorcycle = value;
                }
            }
        }

        public int NumberOfWins
        {
            get
            {
                return this.numberOfWins;
            }
            private set
            {
                this.numberOfWins = value;
            }
        }

        public bool CanParticipate
        {
            get
            {
                return this.Motorcycle != null;
            }
        }

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            this.Motorcycle = motorcycle;
        }

        public void WinRace()
        {
            NumberOfWins += 1;
        }
    }
}
