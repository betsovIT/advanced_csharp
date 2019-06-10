using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> leftSocks = new Stack<int>(Console.ReadLine().Split().Select(n => int.Parse(n)));
            Queue<int> rightSocks = new Queue<int>(Console.ReadLine().Split().Select(n => int.Parse(n)));
            List<int> pairs = new List<int>();

            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                int leftSock = leftSocks.Peek();
                int rightSock = rightSocks.Peek();

                if (leftSock > rightSock)
                {
                    leftSocks.Pop();
                    rightSocks.Dequeue();

                    pairs.Add(leftSock + rightSock);
                }
                else if (leftSock < rightSock)
                {
                    while (leftSocks.Count > 0)
                    {
                        leftSocks.Pop();
                        if (leftSocks.Count == 0)
                        {
                            break;
                        }
                        leftSock = leftSocks.Peek();

                        if (leftSock < rightSock)
                        {
                            continue;
                        }
                        else if (leftSock > rightSock)
                        {
                            leftSocks.Pop();
                            rightSocks.Dequeue();

                            pairs.Add(leftSock + rightSock);

                            break;
                        }
                        else
                        {
                            rightSocks.Dequeue();
                            leftSock = leftSocks.Pop() + 1;
                            leftSocks.Push(leftSock);

                            break;
                        }
                    }
                }
                else
                {
                    rightSocks.Dequeue();
                    leftSock = leftSocks.Pop() + 1;
                    leftSocks.Push(leftSock);
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(' ', pairs));
        }
    }
}
