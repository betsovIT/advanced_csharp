using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < commandsCount; i++)
            {
                int[] command = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                }
                else if (command[0] == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (command[0] == 3 && stack.Count > 0)
                {
                    int[] stackCopy = new int[stack.Count];
                    stack.CopyTo(stackCopy, 0);

                    Console.WriteLine(stackCopy.Max());

                }
                else if (command[0] == 4 && stack.Count > 0)
                {
                    int[] stackCopy = new int[stack.Count];
                    stack.CopyTo(stackCopy, 0);

                    Console.WriteLine(stackCopy.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
