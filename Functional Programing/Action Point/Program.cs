using System;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = n => Console.WriteLine(n);
            string[] names = Console.ReadLine().Split();
            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
