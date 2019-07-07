using System;

namespace ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            double boxLength = double.Parse(Console.ReadLine());
            double boxWidth = double.Parse(Console.ReadLine());
            double boxHeight = double.Parse(Console.ReadLine());

            try
            {
                var box = new Box(boxLength, boxWidth, boxHeight);

                Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.CalculateVolume():F2}");
            }

            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
            }

        }

    }
}
