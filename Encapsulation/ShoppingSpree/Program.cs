using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peopleInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productsInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            var people = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();

            try
            {
                for (int i = 0; i < peopleInput.Length; i++)
                {
                    string[] arguments = peopleInput[i]
                        .Split('=', StringSplitOptions.RemoveEmptyEntries);

                    people.Add(arguments[0], new Person(arguments[0], decimal.Parse(arguments[1])));
                }

                for (int i = 0; i < productsInput.Length; i++)
                {
                    string[] arguments = productsInput[i]
                        .Split('=', StringSplitOptions.RemoveEmptyEntries);

                    products.Add(arguments[0], new Product(arguments[0], decimal.Parse(arguments[1])));
                }

                while (true)
                {
                    string[] input = Console.ReadLine().Split();
                    if (input[0] == "END")
                    {
                        break;
                    }

                    string person = input[0];
                    string product = input[1];

                    people[person].Buy(products[product]);
                }

                foreach (var person in people)
                {
                    if (person.Value.Products.Count > 0)
                    {
                        Console.WriteLine($"{person.Key} - {string.Join(", ", person.Value.Products)}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Key} - Nothing bought");
                    }                    
                }
            }
            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
            }

        }
    }
}
