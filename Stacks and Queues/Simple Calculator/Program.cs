using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] expression = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(expression.Reverse());

            while (stack.Count > 1)
            {
                int num1 = int.Parse(stack.Pop());
                string opperation = stack.Pop();
                int num2 = int.Parse(stack.Pop());

                if (opperation == "+")
                {                   
                    stack.Push((num1+num2).ToString());
                }
                else if (opperation == "-")
                {
                    stack.Push((num1 - num2).ToString());
                }
            }

            Console.WriteLine(stack.Pop());            
        }
    }
}
