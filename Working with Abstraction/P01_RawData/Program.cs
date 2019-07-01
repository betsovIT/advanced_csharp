using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{

    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];
                Engine engine = new Engine(int.Parse(parameters[1]), int.Parse(parameters[2]));
                Cargo cargo = new Cargo(int.Parse(parameters[3]), parameters[4]);

                Tire[] tires = new Tire[]
                {
                    new Tire(double.Parse(parameters[5]),int.Parse(parameters[6])),
                    new Tire(double.Parse(parameters[7]),int.Parse(parameters[8])),
                    new Tire(double.Parse(parameters[9]),int.Parse(parameters[10])),
                    new Tire(double.Parse(parameters[11]),int.Parse(parameters[12])),

                };

                cars.Add(new Car(model, engine ,cargo, tires));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
    }
}
