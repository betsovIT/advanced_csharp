using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    class Commando : ICommando
    {
        public List<Mission> Missions { get; set; }
        public string Corps { get; set; }
        public decimal Salary { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Commando(int id, string firstName, string lastName, decimal salary, string corps)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Corps = corps;
            Missions = new List<Mission>();
        }

        public void AddMission(Mission mission)
        {
            if (mission.State == "inProgress" || mission.State == "Finished")
            {
                Missions.Add(mission);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");

            foreach (var mission in Missions)
            {
                sb.AppendLine("  " + mission.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
