using System;
using System.Collections.Generic;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var reservations = Console.ReadLine()
                .Split()
                .ToDictionary(x => x, y => true);

            Func<KeyValuePair<string, bool>, bool> predicate;

            while (true)
            {
                string[] input = Console.ReadLine().Split(';');
                if (input[0] == "Print")
                {
                    break;
                }
                string command = input[0];
                string filter = input[1];
                string parameter = input[2];

                predicate = GetFilter(filter, parameter);

                if (command == "Add filter")
                {
                    var reservationsSelection = new Dictionary<string,bool>(reservations.Where(predicate));
                    foreach (var person in reservationsSelection)
                    {
                        reservations[person.Key] = false;
                    }
                }
                else if (command == "Remove filter")
                {
                    var reservationsSelection = new Dictionary<string, bool>(reservations.Where(predicate));
                    foreach (var person in reservationsSelection)
                    {
                        reservations[person.Key] = true;
                    }
                }
            }

            foreach (var person in reservations.Where(x => x.Value == true))
            {
                Console.Write($"{person.Key} ");
            }
        }

        public static Func<KeyValuePair<string, bool>, bool> GetFilter(string filter, string parameter)
        {
            if (filter == "Starts with")
            {
                return n => n.Key.StartsWith(parameter);
            }

            if (filter == "Ends with")
            {
                return n => n.Key.EndsWith(parameter);
            }

            if (filter == "Length")
            {
                return n => n.Key.Length == int.Parse(parameter);
            }

            if (filter == "Contains")
            {
                return n => n.Key.Contains(parameter);
            }

            return null;
        }
    }
}
