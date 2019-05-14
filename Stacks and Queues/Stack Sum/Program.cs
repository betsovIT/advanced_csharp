using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }

                string[] operation = input.Split();

                if (operation[0].ToLower() == "add")
                {
                    numbers.Push(int.Parse(operation[1]));
                    numbers.Push(int.Parse(operation[2]));
                }
                else if (operation[0].ToLower() == "remove" && numbers.Count >= int.Parse(operation[1]))
                {
                    int numsToRemove = int.Parse(operation[1]);

                    for (int i = 0; i < numsToRemove; i++)
                    {
                        numbers.Pop();
                    }
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
