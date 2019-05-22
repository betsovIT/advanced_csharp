using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggersWithFollowers = new Dictionary<string, SortedSet<string>>();
            var followingCount = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Statistics")
                {
                    break;
                }

                string vlogger = input[0];
                string action = input[1];

                if (action == "joined" && !vloggersWithFollowers.ContainsKey(vlogger))
                {
                    vloggersWithFollowers.Add(vlogger, new SortedSet<string>());
                    followingCount.Add(vlogger, 0);
                }
                else
                {
                    string toFollow = input[2];
                    if (!vloggersWithFollowers.ContainsKey(vlogger) || !vloggersWithFollowers.ContainsKey(toFollow))
                    {
                        continue;
                    }
                    else
                    {
                        if (vlogger != toFollow && !vloggersWithFollowers[toFollow].Contains(vlogger))
                        {
                            vloggersWithFollowers[toFollow].Add(vlogger);
                            followingCount[vlogger]++;
                        }                        
                    }
                }
            }

            var sortedVloggers = vloggersWithFollowers
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => followingCount[x.Key]).ToDictionary(x => x.Key, x=> x.Value);

            Console.WriteLine($"The V-Logger has a total of {sortedVloggers.Count} vloggers in its logs.");
            int counter = 1;
            foreach (var vlogger in sortedVloggers)
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.Count} followers, {followingCount[vlogger.Key]} following");
                if (vlogger.Key == sortedVloggers.ElementAt(0).Key)
                {
                    foreach (var item in vlogger.Value)
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                counter++;
            }
        }
    }
}
