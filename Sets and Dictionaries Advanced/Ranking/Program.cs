using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var candidates = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests")
                {
                    break;
                }
                string contest = input.Split(':', StringSplitOptions.RemoveEmptyEntries)[0];
                string password = input.Split(':', StringSplitOptions.RemoveEmptyEntries)[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of submissions")
                {
                    break;
                }

                string contest = input.Split("=>", StringSplitOptions.RemoveEmptyEntries)[0];
                string password = input.Split("=>", StringSplitOptions.RemoveEmptyEntries)[1];
                string user = input.Split("=>", StringSplitOptions.RemoveEmptyEntries)[2];
                int points = int.Parse(input.Split("=>", StringSplitOptions.RemoveEmptyEntries)[3]);

                if (!contests.ContainsKey(contest))
                {
                    continue;
                }
                if (contests[contest] != password)
                {
                    continue;
                }
                if (!candidates.ContainsKey(user))
                {
                    candidates.Add(user, new Dictionary<string, int>());
                }
                if (!candidates[user].ContainsKey(contest))
                {
                    candidates[user].Add(contest, points);
                }
                else
                {
                    if (candidates[user][contest] < points)
                    {
                        candidates[user][contest] = points;
                    }
                }
            }

            var bestCandidate = candidates.Where(x => x.Value.Values.Sum() == candidates.Max(y => y.Value.Values.Sum()))
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Best candidate is {bestCandidate.ElementAt(0).Key} with total {bestCandidate.ElementAt(0).Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in candidates)
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
