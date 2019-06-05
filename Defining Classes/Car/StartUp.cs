using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Renault";
            myCar.Model = "Megan";
            myCar.Year = 1992;

            Console.WriteLine($"Make: {myCar.Make}\nModel: {myCar.Model}\nYear: {myCar.Year}");            
        }
    }
}
