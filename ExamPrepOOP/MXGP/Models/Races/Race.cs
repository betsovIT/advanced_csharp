using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders.Contracts;
using MXGP.Repositories;
using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Races
{
    public class Race : IRace
    {
        private string name;
        private int laps;
        private RiderRepository riderRepository;

        public Race(string name, int laps)
        {
            this.Name = name;
            this.Laps = laps;
            riderRepository = new RiderRepository();
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
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidNumberOfLaps, value));
                }
                else
                {
                    this.laps = value;
                }
            }
        }

        public IReadOnlyCollection<IRider> Riders => riderRepository.GetAll();

        public void AddRider(IRider rider)
        {
            riderRepository.Add(rider);
        }
    }
}
