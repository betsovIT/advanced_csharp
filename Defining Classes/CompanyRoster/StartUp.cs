using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var roster = new List<Employee>();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    roster.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3]));
                }
                else if (input.Length == 6)
                {
                    roster.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4], int.Parse(input[5])));
                }
                else if (input.Length == 5)
                {
                    int salary;

                    if (int.TryParse(input[4],out salary))
                    {
                        roster.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], salary));
                    }
                    else
                    {
                        roster.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4]));
                    }
                }
            }

            var highestPayingDepartment = from employee in roster
                                          group employee by employee.Department into departments
                                          select new
                                          {
                                              Department = departments.Key,
                                              AverageSalary = departments.Average(n => n.Salary)
                                          };
            string department = highestPayingDepartment.OrderByDescending(n => n.AverageSalary).FirstOrDefault().Department;

            Console.WriteLine($"Highest Average Salary: {department}");
            foreach (var employee in roster.Where(e => e.Department == department).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
