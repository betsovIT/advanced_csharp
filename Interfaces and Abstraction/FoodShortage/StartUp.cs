using System;
using System.Collections.Generic;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            var buyers = new Dictionary<string,IBuyer>();

            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    buyers.Add(input[0],new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                }
                else if (input.Length == 3)
                {
                    buyers.Add(input[0], new Rebel(input[0], int.Parse(input[1]), input[2]));
                }
            }

            int sum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (buyers.ContainsKey(input))
                {
                    buyers[input].BuyFood();
                }
            }

            foreach (var buyer in buyers.Values)
            {
                sum += buyer.Food;
            }

            Console.WriteLine(sum);
        }
    }
}
