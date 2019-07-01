using System;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                printRow(i,count);
            }

            for (int i = count-1; i > 0; i--)
            {
                printRow(i,count);
            }
        }

        private static void printRow(int stars, int totalStars)
        {
            for (int i = 0; i < totalStars-stars; i++)
            {
                Console.Write(' ');
            }

            for (int i = 1; i < stars; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }
    }
}
