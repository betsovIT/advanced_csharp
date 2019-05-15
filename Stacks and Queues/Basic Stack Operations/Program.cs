using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] specialNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int stackSize = specialNumbers[0];
            int itemsToPop = specialNumbers[1];
            int itemToFind = specialNumbers[2];

            int stackMinNumber = int.MaxValue;

            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            int numsAvailableToPush = Math.Min(inputNumbers.Length, stackSize);

            for (int i = 0; i < numsAvailableToPush; i++)
            {
                stack.Push(inputNumbers[i]);
            }

            int numsAvailableToPop = Math.Min(stack.Count, itemsToPop);

            for (int i = 0; i < numsAvailableToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (stack.Count > 0)
            {
                int num = stack.Pop();
                if (num == itemToFind)
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    if (num < stackMinNumber)
                    {
                        stackMinNumber = num;
                    }
                }
            }

            Console.WriteLine(stackMinNumber);
        }
    }
}
