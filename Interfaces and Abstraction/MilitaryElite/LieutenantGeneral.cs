using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    class LieutenantGeneral : ILieutenantGeneral
    {
        public List<IPrivate> Privates { get; set; }
        public decimal Salary { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Privates = new List<IPrivate>();

        }

        public void AddPrivate(Private @private)
        {
            Privates.Add(@private);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine("Privates:");

            foreach (var @private in Privates)
            {
                sb.AppendLine("  " + @private.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
