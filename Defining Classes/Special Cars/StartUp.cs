using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tireCatalog = new List<Tire[]>();
            var engineCatalog = new List<Engine>();
            var carCatalog = new List<Car>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "No more tires")
                {
                    break;
                }

                string[] tiresAsString = input.Split(' ');
                Tire[] tiresAsArray = new Tire[4];
                int counter = 0;
                for (int i = 0; i < tiresAsArray.Length; i++)
                {
                    tiresAsArray[i] = new Tire(int.Parse(tiresAsString[counter]), double.Parse(tiresAsString[counter + 1]));
                    counter += 2;                    
                }

                tireCatalog.Add(tiresAsArray);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Engines done")
                {
                    break;
                }

                int horsePower = int.Parse(input.Split(' ')[0]);
                double cubicCapacity = double.Parse(input.Split(' ')[1]);

                engineCatalog.Add(new Engine(horsePower, cubicCapacity));
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Show special")
                {
                    break;
                }

                string[] inputAsArray = input.Split(' ');

                string make = inputAsArray[0];
                string model = inputAsArray[1];
                int year = int.Parse(inputAsArray[2]);
                double fuelQuantity = double.Parse(inputAsArray[3]);
                double fuelConsumption = double.Parse(inputAsArray[4]);
                Tire[] tires = tireCatalog[int.Parse(inputAsArray[5])];
                Engine engine = engineCatalog[int.Parse(inputAsArray[6])];

                carCatalog.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires));
                
            }
            foreach (var specialCar in carCatalog)
            {
                if (specialCar.Year >= 2017 
                        && specialCar.Engine.HorsePower > 330 
                            && specialCar.Tires.Sum(n => n.Pressure) >= 9 
                                && specialCar.Tires.Sum(n => n.Pressure) <= 10)
                {
                    specialCar.Drive(20);

                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine($"Make: {specialCar.Make}");
                    sb.AppendLine($"Model: {specialCar.Model}");
                    sb.AppendLine($"Year: {specialCar.Year}");
                    sb.AppendLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                    sb.AppendLine($"FuelQuantity: {specialCar.FuelQuantity}");

                    Console.WriteLine(sb.ToString());
                }
            }
        }
    }
    public class Car
    {

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            if (distance * this.FuelConsumption / 100 > this.FuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                this.FuelQuantity -= this.FuelConsumption / 100 * distance;
            }
        }

        public string WhoAmI()
        {
            StringBuilder carInfo = new StringBuilder();

            carInfo.AppendLine($"Make: {this.Make}");
            carInfo.AppendLine($"Model: {this.Model}");
            carInfo.AppendLine($"Year: {this.Year}");
            carInfo.Append($"Fuel: {this.FuelQuantity:F2}L");

            return carInfo.ToString();
        }
    }
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
    public class Tire
    {
        private int year;
        private double pressure;

        public int Year { get; set; }
        public double Pressure { get; set; }

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
