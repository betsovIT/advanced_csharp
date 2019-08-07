using PlayersAndMonsters.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            var controller = new ManagerController();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Exit")
                {
                    break;
                }

                string[] command = input.Split();
                string commandName = command[0];

                try
                {
                    if (commandName == "AddPlayer")
                    {
                        string playerType = command[1];
                        string playerName = command[2];
                        Console.WriteLine(controller.AddPlayer(playerType, playerName));
                    }
                    else if (commandName == "AddCard")
                    {
                        string cardType = command[1];
                        string cardName = command[2];
                        Console.WriteLine(controller.AddCard(cardType,cardName));
                    }
                    else if (commandName == "AddPlayerCard")
                    {
                        string userName = command[1];
                        string cardName = command[2];
                        Console.WriteLine(controller.AddPlayerCard(userName,cardName));
                    }
                    else if (commandName == "Fight")
                    {
                        string attackPlayer = command[1];
                        string enemyPlayer = command[2];
                        Console.WriteLine(controller.Fight(attackPlayer,enemyPlayer));
                    }
                    else if (commandName == "Report")
                    {
                        Console.WriteLine(controller.Report());
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
