using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            var register = new HashSet<string>();
            for (int i = 0; i < entries; i++)
            {
                string input = Console.ReadLine();
                register.Add(input);
            }
            foreach (var name in register)
            {
                Console.WriteLine(name);
            }
        }
    }
}
