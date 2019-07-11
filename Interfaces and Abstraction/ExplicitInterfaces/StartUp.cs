using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                var citizen = new Citizen(input[0], input[1], int.Parse(input[2]));

                IResident citizen1 = citizen;
                IPerson citizen2 = citizen;
                Console.WriteLine(citizen2.GetName());
                Console.WriteLine(citizen1.GetName());
                

            }
        }
    }
}
