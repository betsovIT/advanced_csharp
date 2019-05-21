using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            var citiesInContinents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!citiesInContinents.ContainsKey(continent))
                {
                    citiesInContinents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!citiesInContinents[continent].ContainsKey(country))
                {
                    citiesInContinents[continent].Add(country, new List<string>());
                }

                citiesInContinents[continent][country].Add(city);
            }
            foreach (var continent in citiesInContinents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
