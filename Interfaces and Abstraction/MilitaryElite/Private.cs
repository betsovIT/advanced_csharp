using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    class Private : IPrivate
    {
        public decimal Salary { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Private(int id, string firstName, string lastName, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}";
        }
    }
}
