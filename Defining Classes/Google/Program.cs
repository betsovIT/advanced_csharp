using System;

namespace Google
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();

            while (true)
            {
                string[] inp = Console.ReadLine().Split();
                if (inp[0] == "End")
                {
                    break;
                }
                

                if (inp[1] == "pokemon")
                {
                    var pokemon = new Pokemon(inp[2], inp[3]);

                    people.Roster.Add(inp[0], new Person(inp[0], pokemon));
                }

                else if (inp[1] == "company")
                {
                    var company = new Company(inp[2], inp[3], double.Parse(inp[4]));
                }
                
            }

            string personToPrint = Console.ReadLine();

            people.Roster[personToPrint].ToString();
        }
    }
}
