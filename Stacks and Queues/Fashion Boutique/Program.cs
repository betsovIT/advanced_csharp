using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int rackContents = 0;

            while (stack.Count > 0)
            {
                if (stack.Peek()+rackContents <= rackCapacity)
                {
                    rackContents += stack.Pop();
                }
                else
                {
                    rackContents = 0;
                    racks++;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
