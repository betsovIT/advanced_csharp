namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Common;
    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private IList<Pilot> pilots;
        private IList<BaseMachine> machines;

        public MachinesManager()
        {
            this.pilots = new List<Pilot>();
            this.machines = new List<BaseMachine>();
        }
        public string HirePilot(string name)
        {
            if (pilots.Any(n => n.Name == name))
            {
                return string.Format(OutputMessages.PilotExists, name);
            }
            else
            {
                pilots.Add(new Pilot(name));
                return string.Format(OutputMessages.PilotHired, name);
            }
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (machines.Any(m => m.Name == name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }
            else
            {
                machines.Add(new Tank(name, attackPoints, defensePoints));
                return string.Format(OutputMessages.TankManufactured, name, attackPoints - 40, defensePoints + 30);
            }
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (machines.Any(m => m.Name == name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }
            else
            {
                machines.Add(new Fighter(name, attackPoints, defensePoints));
                return string.Format(OutputMessages.FighterManufactured, name, attackPoints + 50, defensePoints - 25, "ON");
            }
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            IMachine machine = machines.FirstOrDefault(m => m.Name == selectedMachineName);
            IPilot pilot = pilots.FirstOrDefault(p => p.Name == selectedPilotName);

            if (!pilots.Any(p => p.Name == selectedPilotName))
            {
                return string.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }
            else if (!machines.Any(m => m.Name == selectedMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, selectedMachineName);
            }
            else if (machines.First(m => m.Name == selectedMachineName).Pilot != null)
            {
                return string.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);
            }
            else if (machines.First(m => m.Name == selectedMachineName).Pilot is null)
            {
                machine.Pilot = pilot;
                pilot.AddMachine(machine);
                return string.Format(OutputMessages.MachineEngaged, selectedPilotName, selectedMachineName);
            }

            return null;
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            IMachine attackMachine = machines.FirstOrDefault(m => m.Name == attackingMachineName);
            IMachine defenceMachine = machines.FirstOrDefault(m => m.Name == defendingMachineName);

            if (attackMachine == null)
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }
            else if (defenceMachine == null)
            {
                return string.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }
            else if (attackMachine.HealthPoints == 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attackingMachineName);
            }
            else if (defenceMachine.HealthPoints == 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, defendingMachineName);
            }
            else
            {
                attackMachine.Attack(defenceMachine);
                return string.Format(OutputMessages.AttackSuccessful, defendingMachineName, attackingMachineName, defenceMachine.HealthPoints);
            }
        }

        public string PilotReport(string pilotReporting)
        {
            return pilots.Where(p => p.Name == pilotReporting).FirstOrDefault().Report();
        }

        public string MachineReport(string machineName)
        {
            return machines.Where(p => p.Name == machineName).FirstOrDefault().ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if (machines.Any(m => m.Name == fighterName && m.GetType().Name == "Fighter"))
            {
                IFighter tank = (IFighter)machines.Where(m => m.Name == fighterName && m.GetType().Name == "Fighter").First();
                tank.ToggleAggressiveMode();
                return string.Format(OutputMessages.FighterOperationSuccessful, fighterName);
            }
            else
            {
                return string.Format(OutputMessages.MachineNotFound, fighterName);
            }
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            if (machines.Any(m => m.Name == tankName && m.GetType().Name == "Tank"))
            {
                ITank tank = (ITank)machines.Where(m => m.Name == tankName && m.GetType().Name == "Tank").First();
                tank.ToggleDefenseMode();
                return string.Format(OutputMessages.TankOperationSuccessful, tankName);
            }
            else
            {
                return string.Format(OutputMessages.MachineNotFound, tankName);
            }
        }
    }
}