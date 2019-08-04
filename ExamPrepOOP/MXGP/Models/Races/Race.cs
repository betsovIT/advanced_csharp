using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders.Contracts;
using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MXGP.Models.Races
{
    public class Race : IRace
    {
        private string name;
        private int laps;
        private List<IRider> riders;

        public Race(string name, int laps)
        {
            this.Name = name;
            this.Laps = laps;
            riders = new List<IRider>();
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

        public int Laps
        {
            get
            {
                return this.laps;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidNumberOfLaps,1));
                }
                else
                {
                    this.laps = value;
                }
            }
        }

        public IReadOnlyCollection<IRider> Riders => new ReadOnlyCollection<IRider>(riders);

        public void AddRider(IRider rider)
        {
            if (rider is null)
            {
                throw new ArgumentNullException(string.Format(ExceptionMessages.RiderInvalid));
            }
            else if (rider.Motorcycle is null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RiderNotParticipate,rider.Name));
            }
            else if (riders.Any(r => r.Name == rider.Name))
            {
                throw new ArgumentNullException(string.Format(ExceptionMessages.RiderAlreadyAdded,rider.Name,this.Name));
            }
            else
            {
                riders.Add(rider);
            }            
        }
    }
}
