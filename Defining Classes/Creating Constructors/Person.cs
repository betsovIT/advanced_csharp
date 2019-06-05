using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age)
            :this()
        {
            this.Age = age;
        }
        public Person(string name, int age)
            :this(age)
        {
            this.Name = name;
        }
    }
}
