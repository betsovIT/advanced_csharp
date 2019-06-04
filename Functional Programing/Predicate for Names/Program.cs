using System;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredLength = int.Parse(Console.ReadLine());
            Func<int, string, bool> lengthEvaluator = (count, name) => name.Length <= count;
            string[] names = Console.ReadLine().Split();
            foreach (string name in names)
            {
                if (lengthEvaluator(desiredLength,name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
