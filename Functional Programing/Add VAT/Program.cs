using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            Func<double,double> vATAdder = n => n * 1.2;
            foreach (double price in prices)
            {
                Console.WriteLine($"{vATAdder(price):F2}");
            }
        }
    }
}
