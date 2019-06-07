using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            var engines = new Dictionary<string, Engine>();
            var cars = new List<Car>();

            //Filling up the engine collection
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int power = int.Parse(input[1]);
                string displacement = "n/a";
                string efficiency = "n/a";

                if (input.Length == 3)
                {
                    if (Char.IsDigit(input[2][0]))
                    {
                        displacement = input[2];
                    }
                    else
                    {
                        efficiency = input[2];
                    }
                }

                if (input.Length == 4)
                {
                    displacement = input[2];
                    efficiency = input[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(input[0], engine);
            }


            //Filling up the car collection
            int M = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                Engine engine = engines[input[1]];
                string weight = "n/a";
                string color = "n/a";

                if (input.Length == 3)
                {
                    if (Char.IsDigit(input[2][0]))
                    {
                        weight = input[2];
                    }
                    else
                    {
                        color = input[2];
                    }
                }

                if (input.Length == 4)
                {
                    weight = input[2];
                    color = input[3];
                }

                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine(string.Format($"    Displacement: {car.Engine.Displacement}"));
                Console.WriteLine(string.Format($"    Efficiency: {car.Engine.Efficiency}"));
                Console.WriteLine(string.Format($"  Weight: {car.Weight}"));
                Console.WriteLine(string.Format($"  Color: {car.Color}"));
            }
        }
    }
}
