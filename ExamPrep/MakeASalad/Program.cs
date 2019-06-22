using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            var energyValue = new Dictionary<string, int>()
            {
                {"tomato", 80},
                {"carrot", 136},
                {"lettuce", 109},
                {"potato", 215}
            };

            var veggies = new Queue<string>(Console.ReadLine().Split());
            var salads = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            var doneSalads = new Queue<int>();
            var currentCallorieCount = 0;

            while (veggies.Count > 0 && salads.Count > 0)
            {
                int salad = salads.Peek();
                currentCallorieCount += energyValue[veggies.Dequeue()];

                if (veggies.Count == 0)
                {
                    doneSalads.Enqueue(salads.Pop());
                    break;
                }

                if (salad - currentCallorieCount <= 0)
                {
                    doneSalads.Enqueue(salads.Pop());
                    currentCallorieCount = 0;
                }
            }


            if (veggies.Count == 0)
            {
                Console.WriteLine(string.Join(' ', doneSalads));
                Console.WriteLine(string.Join(' ', salads));
            }
            else if (salads.Count == 0)
            {
                Console.WriteLine(string.Join(' ', doneSalads));
                Console.WriteLine(string.Join(' ', veggies));
            }
        }
    }
}
