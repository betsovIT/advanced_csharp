using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            try
            {
                int num = int.Parse(number);

                if (num < 0 )
                {
                    throw new Exception();
                }

                Console.WriteLine(Math.Sqrt(num));
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
