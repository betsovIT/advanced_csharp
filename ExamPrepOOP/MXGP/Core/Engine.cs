using MXGP.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Core
{
    class Engine
    {
        public void Run()
        {
            var controller = new ChampionshipController();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] command = input.Split();

                try
                {
                    if (command[0] == "CreateRider")
                    {
                        controller.CreateRider(command[1]);
                    }
                    else if (command[0] == "CreateMotorcycle")
                    {
                        string type = command[1];
                        string model = command[2];
                        int horsePower = int.Parse(command[3]);

                        Console.WriteLine(controller.CreateMotorcycle(type, model, horsePower));
                    }
                    else if (command[0] == "AddMotorcycleToRider")
                    {
                        string riderName = command[1];
                        string motorcycleName = command[2];

                        Console.WriteLine(controller.AddMotorcycleToRider(riderName, motorcycleName));
                    }
                    else if (command[0] == "AddRiderToRace")
                    {
                        string raceName = command[1];
                        string riderName = command[2];

                        Console.WriteLine(controller.AddRiderToRace(raceName, riderName));
                    }
                    else if (command[0] == "CreateRace")
                    {
                        string name = command[1];
                        int laps = int.Parse(command[2]);

                        Console.WriteLine(controller.CreateRace(name, laps));
                    }
                    else if (command[0] == "StartRace")
                    {
                        string name = command[1];

                        Console.WriteLine( controller.StartRace(name));
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            }

        }
    }
}
