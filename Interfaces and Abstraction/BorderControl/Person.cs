using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Person : IIdentifiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }

        public Person(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public bool CheckIfFake(string lastDigits)
        {
            int countOfDigits = lastDigits.Length;
            string lastDigitsOfID = Id.Substring(Id.Length - countOfDigits , countOfDigits);

            return lastDigits == lastDigitsOfID;
        }
    }
}
