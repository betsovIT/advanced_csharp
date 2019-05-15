using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawSpecialNumbers = Console.ReadLine();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int queueSize = int.Parse(rawSpecialNumbers.Split()[0]);
            int numsToPop = int.Parse(rawSpecialNumbers.Split()[1]);
            int numToFind = int.Parse(rawSpecialNumbers.Split()[2]);

            var queue = new Queue<int>();
            int minNum = int.MaxValue;

            for (int i = 0; i < Math.Min(input.Length, queueSize); i++)
            {
                queue.Enqueue(input[i]);
            }

            int maxNumsToPop = Math.Min(numsToPop, queue.Count);

            for (int i = 0; i < maxNumsToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (queue.Count >= 1)
            {
                int num = queue.Dequeue();

                if (num == numToFind)
                {
                    Console.WriteLine("true");
                    return;
                }

                if (num < minNum)
                {
                    minNum = num;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
