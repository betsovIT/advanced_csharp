using MXGP.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.IO
{
    public class CommandInterpreter
    {
        private ChampionshipController controller;
        public CommandInterpreter(ChampionshipController controller)
        {
            this.controller = controller;
        }

        public string ExecuteCommand(string input)
        {
            string[] command = input.Split();

            string commandType = command[0];

            
            if (commandType == "CreateRider")
            {
                string name = command[1];

                return controller.CreateRider(name);
            }
            else if (commandType == "CreateMotorcycle")
            {
                string type = command[1];
                string model = command[2];
                int horsePower = int.Parse(command[3]);

                return controller.CreateMotorcycle(type, model, horsePower);
            }
            else if (commandType == "AddMotorcycleToRider")
            {
                string riderName = command[1];
                string motorcycleName = command[2];

                return controller.AddMotorcycleToRider(riderName, motorcycleName);
            }
            else if (commandType == "AddRiderToRace")
            {
                string raceName = command[1];
                string riderName = command[2];

                return controller.AddRiderToRace(raceName, riderName);
            }
            else if (commandType == "CreateRace")
            {
                string name = command[1];
                int laps = int.Parse(command[2]);

                return controller.CreateRace(name, laps);
            }
            else if (commandType == "StartRace")
            {
                string name = command[1];

                return controller.StartRace(name);
            }
            else
            {
                controller.Exit();
                return null;
            }
        }
    }
}
