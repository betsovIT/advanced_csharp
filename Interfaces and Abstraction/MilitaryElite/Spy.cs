using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    class Spy : ISpy
    {
        public int CodeNumber { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Spy(int id, string firstName, string lastName, int codeNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}\nCode Number: {CodeNumber}";
        }
    }
}
