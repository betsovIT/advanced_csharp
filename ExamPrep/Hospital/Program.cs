using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new Dictionary<string, List<string>>();
            var doctors = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Output")
                {
                    break;
                }
                string department = input[0];
                string doctor = input[1] + ' ' + input[2];
                string patient = input[3];

                if (!departments.ContainsKey(department))
                {
                    departments.Add(department, new List<string>());
                }

                if (!doctors.ContainsKey(doctor))
                {
                    doctors.Add(doctor, new List<string>());
                }

                if (departments[department].Count < 60)
                {
                    departments[department].Add(patient);
                }

                doctors[doctor].Add(patient);
            }
            while (true)
            {
                string[] whatToPrint = Console.ReadLine().Split();

                if (whatToPrint[0] == "End")
                {
                    break;
                }

                if (whatToPrint.Length == 1)
                {
                    foreach (var patient in departments[whatToPrint[0]])
                    {
                        Console.WriteLine(patient);
                    }
                }
                else
                {
                    if (Char.IsDigit(whatToPrint[1][0]))
                    {
                        string department = whatToPrint[0];
                        int room = int.Parse(whatToPrint[1]);
                        int indexToStartFrom = ((room - 1) * 3);

                        foreach (var patient in departments[department].GetRange(indexToStartFrom, 3).OrderBy(n => n))
                        {
                            Console.WriteLine(patient);
                        }

                    }
                    else
                    {
                        foreach (var patient in doctors[whatToPrint[0] + ' ' + whatToPrint[1]].OrderBy(n => n))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }
            }
            
        }
    }
}
