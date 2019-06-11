using System;
using System.Collections.Generic;

namespace CustomStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomList();
            var list2 = new CustomList(50);

            list.Add(7);
            list.Add(12);
            list.Add(23);

            list.AddRange(new int[] { 7, 34, 56, 12, 89, 65, 34, 2 });
            list.RemoveAt(3);
            //list.InsertAt(1456, 90);
            list.InsertAt(4, 8);
            list.Swap(0, 8);

            list.ForEach(Console.Write);

            Stack<int> steck = new Stack<int>();
            steck.Push(5);
            steck.Push(7);
            steck.Push(7);
            steck.Push(7);
            steck.Push(7);
            steck.Push(7);
            steck.Push(7);

            foreach (var item in steck)
            {
                Console.WriteLine(item);
            }
        }
    }
}
