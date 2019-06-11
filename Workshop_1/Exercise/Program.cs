using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DobulyLinkedList();

            doublyLinkedList.AddFirst(1);
            doublyLinkedList.AddFirst(2);
            doublyLinkedList.AddFirst(3);

            doublyLinkedList.RemoveFirst();

            doublyLinkedList.Print(Console.WriteLine);
            Console.WriteLine(doublyLinkedList.Count == 3);
        }
    }
}