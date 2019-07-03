using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            var doctors = new Dictionary<string, List<string>>();
            var departments = new Dictionary<string, List<List<string>>>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] args = command.Split();
                var departament = args[0];
                var firstName = args[1];
                var lastName = args[2];
                var pacient = args[3];
                var fullName = firstName + lastName;

                if (!doctors.ContainsKey(fullName))
                {
                    doctors[fullName] = new List<string>();
                }
                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();
                    for (int room = 0; room < 20; room++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool hasSpace = departments[departament].SelectMany(x => x).Count() < 60;

                if (hasSpace)
                {
                    int room = 0;
                    doctors[fullName].Add(pacient);

                    for (int r = 0; r < departments[departament].Count; r++)
                    {
                        if (departments[departament][r].Count < 3)
                        {
                            room = r;
                            break;
                        }
                    }
                    departments[departament][room].Add(pacient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    string department = args[0];
                    Console.WriteLine(string.Join("\n", departments[department].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int room))
                {
                    string department = args[0];
                    Console.WriteLine(string.Join("\n", departments[department][room - 1].OrderBy(x => x)));
                }
                else
                {
                    string doctor = args[0] + args[1];
                    Console.WriteLine(string.Join("\n", doctors[doctor].OrderBy(x => x)));
                }

                command = Console.ReadLine();
            }
        }
    }
}
