using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    class Pet : IBorn
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public bool CheckBirthdate(string year)
        {
            string yearOfBirth = Birthdate.Substring(Birthdate.Length - 4, 4);

            return yearOfBirth == year;
        }
    }
}
