using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var entities = new List<IBorn>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }

                if (input[0] == "Citizen")
                {
                    entities.Add(new Person(input[1], int.Parse(input[2]), input[3], input[4]));
                }
                else if (input[0] == "Pet")
                {
                    entities.Add(new Pet(input[1], input[2]));
                }
            }

            string year = Console.ReadLine();

            foreach (var entity in entities)
            {
                if (entity.CheckBirthdate(year))
                {
                    Console.WriteLine(entity.Birthdate);
                }
            }
        }
    }
}
