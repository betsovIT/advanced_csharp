using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var soldiers = new Dictionary<int, ISoldier>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                int id = int.Parse(input[1]);
                string firstName = input[2];
                string lastName = input[3];
                

                if (input[0] == "Private")
                {
                    decimal salary = decimal.Parse(input[4]);
                    soldiers.Add(id,new Private(id, firstName, lastName, salary));
                }
                else if (input[0] == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(input[4]);
                    var general = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < input.Length; i++)
                    {
                        Private @private = (Private)soldiers[int.Parse(input[i])];
                        general.AddPrivate(@private);
                    }

                    soldiers.Add(id, general);
                }
                else if (input[0] == "Commando")
                {
                    decimal salary = decimal.Parse(input[4]);
                    string corps = input[5];
                    if (corps != "Airforces" && corps != "Marines")
                    {
                        continue;
                    }

                    var commando = new Commando(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < input.Length; i+= 2)
                    {
                        var mission = new Mission(input[i], input[i + 1]);
                        commando.AddMission(mission);
                    }

                    soldiers.Add(id, commando);
                }
                else if (input[0] == "Engineer")
                {
                    decimal salary = decimal.Parse(input[4]);
                    string corps = input[5];
                    if (corps != "Airforces" && corps != "Marines")
                    {
                        continue;
                    }

                    var engineer = new Engineer(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < input.Length; i += 2)
                    {
                        var repair = new Repair(input[i], int.Parse(input[i + 1]));
                        engineer.AddRepair(repair);
                    }

                    soldiers.Add(id, engineer);
                }
                else if (input[0] == "Spy")
                {
                    int codeNumber = int.Parse(input[4]);
                    soldiers.Add(id, new Spy(id, firstName, lastName, codeNumber));
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.Value);
            }
        }
    }
}
