using System;
using System.Collections.Generic;
using System.Text;

namespace P03_StudentSystem
{
    public class StudentSystem
    {
        public Dictionary<string, Student> Students { get; private set; }
        public StudentSystem()
        {
            Students = new Dictionary<string, Student>();
        }

        public void ParseCommand()
        {
            string[] args = Console.ReadLine().Split();

            if (args[0] == "Create")
            {
                string name = args[1];
                int age = int.Parse(args[2]);
                double grade = double.Parse(args[3]);
                Create(name, age, grade);
            }
            else if (args[0] == "Show")
            {
                string name = args[1];
                Show(name);
            }
            else if (args[0] == "Exit")
            {
                Environment.Exit(0);
            }
        }

        private void Create(string name, int age, double grade)
        {
            if (!Students.ContainsKey(name))
            {
                this.Students.Add(name, new Student(name, age, grade));
            }            
        }

        private void Show(string name)
        {
            if (Students.ContainsKey(name))
            {
                string commentary = string.Empty;

                if (Students[name].Grade >= 5.0)
                {
                    commentary = "Excellent student.";
                }
                else if (Students[name].Grade >= 3.5 && Students[name].Grade < 5.0)
                {
                    commentary = "Average student.";
                }
                else
                {
                    commentary = "Very nice person.";
                }

                Console.WriteLine($"{ Students[name].Name} is { Students[name].Age } years old. { commentary}");
            }
            
        }
    }
}
