using MortalEngines.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Core
{
    class Engine : IEngine
    {
        public void Run()
        {
            IMachinesManager manager = new MachinesManager();

            

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Quit")
                {
                    break;
                }

                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                string result = string.Empty;

                try
                {
                    switch (command)
                    {
                        case "HirePilot":
                            result = manager.HirePilot(commandArgs[1]);
                            break;
                        case "PilotReport":
                            result = manager.PilotReport(commandArgs[1]);
                            break;
                        case "ManufactureTank":
                            result = manager.ManufactureTank(commandArgs[1], double.Parse(commandArgs[2]), double.Parse(commandArgs[3]));
                            break;
                        case "ManufactureFighter":
                            result = manager.ManufactureFighter(commandArgs[1], double.Parse(commandArgs[2]), double.Parse(commandArgs[3]));
                            break;
                        case "MachineReport":
                            result = manager.MachineReport(commandArgs[1]);
                            break;
                        case "AggressiveMode":
                            result = manager.ToggleFighterAggressiveMode(commandArgs[1]);
                            break;
                        case "DefenseMode":
                            result = manager.ToggleTankDefenseMode(commandArgs[1]);
                            break;
                        case "Engage":
                            result = manager.EngageMachine(commandArgs[1], commandArgs[2]);
                            break;
                        case "Attack":
                            result = manager.AttackMachines(commandArgs[1], commandArgs[2]);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine(result);
            }
        }
    }
}
