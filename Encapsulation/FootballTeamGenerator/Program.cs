using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, Team>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(';');
                if (input[0] == "END")
                {
                    break;
                }

                string command = input[0];

                try
                {
                    if (command == "Team")
                    {
                        string teamName = input[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            teams.Add(teamName, new Team(teamName));
                        }

                    }
                    else if (command == "Add")
                    {
                        string teamName = input[1];
                        string playerName = input[2];
                        int endurance = int.Parse(input[3]);
                        int sprint = int.Parse(input[4]);
                        int dribble = int.Parse(input[5]);
                        int passing = int.Parse(input[6]);
                        int shooting = int.Parse(input[7]);

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            teams[teamName].AddPlayer(new Player(playerName, endurance, sprint, dribble, passing, shooting));
                        }
                    }
                    else if (command == "Remove")
                    {
                        string teamName = input[1];
                        string playerName = input[2];

                        if (teams[teamName].ContainsPlayer(playerName))
                        {
                            teams[teamName].RemovePlayer(playerName);
                        }
                        else
                        {
                            Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                        }
                    }
                    else if (command == "Rating")
                    {
                        string teamName = input[1];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {
                           Console.WriteLine($"{teamName} - {teams[teamName].Rating}"); 
                        }
                    }
                }
                catch (Exception ae)
                {

                    Console.WriteLine(ae.Message);
                }
               
            }
        }
    }
}
