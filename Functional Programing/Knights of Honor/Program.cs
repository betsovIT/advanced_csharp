using System;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string> knightHim = n => Console.WriteLine($"Sir {n}");
            foreach (var name in names)
            {
                knightHim(name);
            }
        }
    }
}
