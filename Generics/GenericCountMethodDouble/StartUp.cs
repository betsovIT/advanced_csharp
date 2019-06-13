using System;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var list = new GenericList<double>();

            for (int i = 0; i < lines; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            double itemToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(list.GetCountOfGreaterElements(itemToCompare));
        }
    }
}
