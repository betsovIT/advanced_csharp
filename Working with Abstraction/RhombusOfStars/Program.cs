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

        private static void printRow(int starts, int totalStars)
        {
            throw new NotImplementedException();
        }
    }
}
