using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] arr = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] token = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = token[j];
                }
            }
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] commandAndArgs = input.Split();
                string command = commandAndArgs[0];
                int row = int.Parse(commandAndArgs[1]);
                int coll = int.Parse(commandAndArgs[2]);
                int num = int.Parse(commandAndArgs[3]);

                if (row > arr.GetLength(0) - 1 || coll > arr.GetLength(1) - 1 || row < 0 || coll < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command == "Add")
                    {
                        arr[row, coll] += num;
                    }
                    else if (command == "Subtract")
                    {
                        arr[row, coll] -= num;
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
