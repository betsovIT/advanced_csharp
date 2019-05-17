using System;
using System.Collections.Generic;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    stack.Push(input[i]);
                }

                else if (input[i] == '}')
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                }

                else if (input[i] == ']')
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

                else if (input[i] == ')')
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
