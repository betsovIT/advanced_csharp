using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    class Engineer : IEngineer
    {
        public List<Repair> Repairs { get; set; }
        public string Corps { get; set; }
        public decimal Salary { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Engineer(int id, string firstName, string lastName,decimal salary, string corps)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Corps = corps;            
            Repairs = new List<Repair>();
        }

        public void AddRepair(Repair repair)
        {
            Repairs.Add(repair);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");

            foreach (var repair in Repairs)
            {
                sb.AppendLine("  " + repair.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
