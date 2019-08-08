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
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 5));
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public IMotorcycle Motorcycle { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate => Motorcycle != null;

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            if (motorcycle is null)
            {
                throw new ArgumentNullException(ExceptionMessages.MotorcycleInvalid);
            }
            else
            {
                Motorcycle = motorcycle;
            }
        }

        public void WinRace()
        {
            NumberOfWins++;
        }
    }
}
