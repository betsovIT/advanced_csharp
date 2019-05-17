using System;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] arr = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string token = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = token[j];
                }
            }

            char specChar = char.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arr[i,j] == specChar)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{specChar} does not occur in the matrix");
        }
    }
}
