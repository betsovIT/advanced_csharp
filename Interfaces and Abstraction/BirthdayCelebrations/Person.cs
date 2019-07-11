using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    class Person : IIdentifiable, IBorn
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get ; set ; }

        public Person(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public bool CheckIfFake(string lastDigits)
        {
            int countOfDigits = lastDigits.Length;
            string lastDigitsOfID = Id.Substring(Id.Length - countOfDigits , countOfDigits);

            return lastDigits == lastDigitsOfID;
        }

        public bool CheckBirthdate(string year)
        {
            string yearOfBirth = Birthdate.Substring(Birthdate.Length - 4, 4);

            return yearOfBirth == year;
        }
    }
}
