using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }
        //public IReadOnlyCollection<Player> Players
        //{
        //    get
        //    {
        //        return players.AsReadOnly();
        //    }
        //}
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Rating
        {
            get
            {
                if (players.Count > 0)
                {
                    return (int)Math.Round(players.Sum(n => n.AverageStats) / players.Count);
                }
                else
                {
                    return 0;
                }
                
            }
        }

        public bool ContainsPlayer(string name)
        {
            return players.Exists(p => p.Name == name);
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(string name)
        {
            players.Remove(players.Where(p => p.Name == name).FirstOrDefault());
        }
    }
}
