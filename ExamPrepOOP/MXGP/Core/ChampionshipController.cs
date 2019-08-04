using MXGP.Core.Contracts;
using MXGP.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MXGP.Utilities.Messages;
using MXGP.Models.Riders;
using MXGP.Models.Motorcycles;
using MXGP.Models.Races;
using MXGP.Models.Riders.Contracts;

namespace MXGP.Core
{
    class ChampionshipController : IChampionshipController
    {
        private RaceRepository raceRepository;
        private RiderRepository riderRepository;
        private MotorcycleRepository motorcycleRepository;

        public ChampionshipController()
        {
            raceRepository = new RaceRepository();
            riderRepository = new RiderRepository();
            motorcycleRepository = new MotorcycleRepository();
        }
        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            if (!riderRepository.GetAll().Any(r => r.Name == riderName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RiderNotFound, riderName));
            }
            else if (!motorcycleRepository.GetAll().Any(m => m.Model == motorcycleModel)) 
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.MotorcycleNotFound, motorcycleModel));
            }
            else
            {
                riderRepository.GetByName(riderName).AddMotorcycle(motorcycleRepository.GetByName(motorcycleModel));
                return string.Format(OutputMessages.MotorcycleAdded, riderName, motorcycleModel);
            }
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            if (!raceRepository.GetAll().Any(r => r.Name == raceName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }
            else if (!riderRepository.GetAll().Any(r => r.Name == riderName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RiderNotFound, riderName));
            }
            else
            {
                raceRepository.GetByName(raceName).AddRider(riderRepository.GetByName(riderName));
                return string.Format(OutputMessages.RiderAdded, riderName, raceName);
            }
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            if (type == "Power")
            {
                PowerMotorcycle powerMotorcycle = new PowerMotorcycle(model, horsePower);

                if (motorcycleRepository.GetAll().Any(m => m.Model == model))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.MotorcycleExists, model));
                }
                else
                {
                    motorcycleRepository.Add(powerMotorcycle);
                    return string.Format(OutputMessages.MotorcycleCreated, type, model);
                }
            }
            else if (type == "Speed")
            {
                SpeedMotorcycle speedMotorcycle = new SpeedMotorcycle(model, horsePower);

                if (motorcycleRepository.GetAll().Any(m => m.Model == model))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.MotorcycleExists, model));
                }
                else
                {
                    motorcycleRepository.Add(speedMotorcycle);
                    return string.Format(OutputMessages.MotorcycleCreated, type, model);
                }
            }
            else
            {
                return null;
            }
        }

        public string CreateRace(string name, int laps)
        {
            if (raceRepository.GetAll().Any(r => r.Name == name))
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
            if (riderRepository.GetAll().Any(r => r.Name == riderName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RiderExists, riderName));
            }
            else
            {
                riderRepository.Add(new Rider(riderName));
                return string.Format(OutputMessages.RiderCreated,riderName);
            }
        }

        public string StartRace(string raceName)
        {
            if (!raceRepository.GetAll().Any(r => r.Name == raceName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }
            else if (raceRepository.GetByName(raceName).Riders.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, 3));
            }
            else
            {
                var riders = new List<IRider>(raceRepository.GetByName(raceName).Riders.OrderByDescending(r => r.Motorcycle.CalculateRacePoints(raceRepository.GetByName(raceName).Laps)));

                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Rider {riders[0].Name} wins {raceName} race.");
                sb.AppendLine($"Rider {riders[1].Name} is second in {raceName} race.");
                sb.AppendLine($"Rider {riders[2].Name} is third in {raceName} race.");

                return sb.ToString().TrimEnd();
            }
        }
    }
}
