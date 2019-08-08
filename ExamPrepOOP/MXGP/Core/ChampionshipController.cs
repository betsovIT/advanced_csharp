using MXGP.Core.Contracts;
using MXGP.Models.Motorcycles;
using MXGP.Models.Races;
using MXGP.Models.Riders;
using MXGP.Models.Riders.Contracts;
using MXGP.Repositories;
using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Core
{
    public class ChampionshipController : IChampionshipController
    {
        private RiderRepository riderRepository;
        private MotorcycleRepository motorcycleRepository;
        private RaceRepository raceRepository;

        public ChampionshipController()
        {
            this.riderRepository = new RiderRepository();
            this.motorcycleRepository = new MotorcycleRepository();
            this.raceRepository = new RaceRepository();
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            if (riderRepository.GetByName(riderName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RiderNotFound, riderName));
            }
            else if (motorcycleRepository.GetByName(motorcycleModel) == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.MotorcycleNotFound, motorcycleModel));
            }
            else
            {
                riderRepository.GetByName(riderName).AddMotorcycle(motorcycleRepository.GetByName(motorcycleModel));

                return string.Format(OutputMessages.MotorcycleAdded, riderName, motorcycleModel);
            }
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            if (raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }
            else if (riderRepository.GetByName(riderName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RiderNotFound, riderName));
            }
            else if (raceRepository.GetByName(raceName).Riders.Any(r => r.Name == riderName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RiderAlreadyAdded, riderName, raceName));
            }
            else if (riderRepository.GetByName(riderName).Motorcycle == null)
            {
                throw new InvalidOperationException(string.Format(string.Format(ExceptionMessages.RiderNotParticipate, riderName)));
            }
            else
            {
                raceRepository.GetByName(raceName).AddRider(riderRepository.GetByName(riderName));

                return string.Format(OutputMessages.RiderAdded, riderName, raceName);
            }
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            if (motorcycleRepository.GetByName(model) != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.MotorcycleExists, model));
            }
            else
            {
                if (type == "Speed")
                {
                    var motorcycle = new SpeedMotorcycle(model, horsePower);
                    motorcycleRepository.Add(motorcycle);

                    return string.Format(OutputMessages.MotorcycleCreated, "SpeedMotorcycle", model);
                }
                else if (type == "Power")
                {
                    var motorcycle = new PowerMotorcycle(model, horsePower);
                    motorcycleRepository.Add(motorcycle);

                    return string.Format(OutputMessages.MotorcycleCreated, "PowerMotorcycle", model);
                }
                else
                {
                    return null;
                }
            }
        }

        public string CreateRace(string name, int laps)
        {
            if (raceRepository.GetByName(name) != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, name));
            }
            else
            {
                raceRepository.Add(new Race(name, laps));

                return string.Format(OutputMessages.RaceCreated, name);
            }
        }

        public string CreateRider(string riderName)
        {
            if (riderRepository.GetByName(riderName) != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RiderExists, riderName));
            }
            else
            {
                riderRepository.Add(new Rider(riderName));
                return string.Format(OutputMessages.RiderCreated, riderName);
            }
        }

        public string StartRace(string raceName)
        {
            if (raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }
            else if (raceRepository.GetByName(raceName).Riders.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, 3));
            }
            else
            {
                int raceLaps = raceRepository.GetByName(raceName).Laps;
                var ridersSorted = raceRepository.GetByName(raceName).Riders.OrderByDescending(r => r.Motorcycle.CalculateRacePoints(raceLaps)).ToList();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(string.Format(OutputMessages.RiderFirstPosition, ridersSorted[0].Name, raceName));
                sb.AppendLine(string.Format(OutputMessages.RiderSecondPosition, ridersSorted[1].Name, raceName));
                sb.AppendLine(string.Format(OutputMessages.RiderThirdPosition, ridersSorted[2].Name, raceName));

                return sb.ToString().TrimEnd();
            }
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
