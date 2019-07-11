using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var listOfPassers = new List<IIdentifiable>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }

                if (input.Length == 2)
                {
                    var robot = new Robot(input[0], input[1]);
                    listOfPassers.Add(robot);
                }
                else if (input.Length == 3)
                {
                    var person = new Person(input[0], int.Parse(input[1]), input[2]);
                    listOfPassers.Add(person);
                }
            }

            string secretDigits = Console.ReadLine();

            foreach (var passer in listOfPassers)
            {
                if (passer.CheckIfFake(secretDigits))
                {
                    Console.WriteLine(passer.Id);
                }
            }
        }
    }
}
