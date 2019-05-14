using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == '(')
                {
                    //Marks the oppening brackets and saves them in the stack
                    indexes.Push(i);
                }
                else if (ch == ')')
                {
                    //Finding a closing bracket it removes the index of the uppermost opening bracket an prints the result in between
                    int startIndex = indexes.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
