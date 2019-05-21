using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < entries; i++)
            {
                string input = Console.ReadLine();

                string student = input.Split()[0];
                double grade = double.Parse(input.Split()[1]);

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                }

                students[student].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> student in students)
            {
                string studentName = student.Key;
                var grades = student.Value;
                var average = student.Value.Average();

                Console.Write(studentName);
                Console.Write(" -> ");
                foreach (var item in grades)
                {
                    Console.Write($"{item:F2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");

            }
        }
    }
}
