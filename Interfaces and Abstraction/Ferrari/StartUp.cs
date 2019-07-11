using System;

namespace Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string driver = Console.ReadLine();

            var ferari = new Ferrari(driver);

            Console.WriteLine($"{ferari.Model}/{ferari.Brake()}/{ferari.PressTheGass()}/{ferari.Driver}");
        }
    }
}
