using System;

namespace TriFunction
{
    class Program
    {
        public delegate bool Checker(string name,int sum);
        static void Main(string[] args)
        {
            int desiredCharSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Action<string[], int, Checker> Main = (x, y, z) =>
              {

                  foreach (string name in x)
                  {
                      if (z(name,y))
                      {
                          Console.WriteLine(name);
                          return;
                      }
                  }
              };

            Main(names, desiredCharSum, nameChecker);
        }

        public static bool nameChecker(string name,int charSum)
        {
            int sum = 0;

            for (int i = 0; i < name.Length; i++)
            {
                sum += name[i];
            }

            if (sum >= charSum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
