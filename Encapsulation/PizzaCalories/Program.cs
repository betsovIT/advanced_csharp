using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string grain = input[1];
            string baking = input[2];
            double grams = double.Parse(input[3]);

            

            try
            {
                Console.WriteLine($"{new Dough(grain, baking, grams).Calories:F2}");
            }
            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
            }
            
        }
    }
}
