using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Employee
    {
        public string Name { get; private set; }
        public double Salary { get; private set; }
        public string Position { get; private set; }
        public string Department { get; private set; }
        public string Email { get; private set; }
        public int Age { get; private set; }

        public Employee(string name, double salary, string position,string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = @"n/a";
            this.Age = -1;
        }
        public Employee(string name, double salary, string position, string department,string email)
            : this(name,salary,position,department)
        {
            this.Email = email;
        }
        public Employee(string name, double salary, string position, string department, int age)
            :this(name, salary, position, department)
        {
            this.Age = age;
        }
        public Employee(string name, double salary, string position, string department, string email,int age)
            : this(name, salary, position, department)
        {
            this.Email = email;
            this.Age = age;
        }

    }
}
