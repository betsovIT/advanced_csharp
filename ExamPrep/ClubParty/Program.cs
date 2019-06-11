using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string[] rawInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var entries = new Stack<string>(rawInput);
            var halls = new Queue<string>();
            var guests = new Queue<int>();

            while (entries.Count > 0)
            {
                string entry = entries.Pop();

                if (Char.IsLetter(entry[0]))
                {
                    halls.Enqueue(entry);
                }
                else
                {
                    if (halls.Count > 0)
                    {
                        guests.Enqueue(int.Parse(entry));
                    }
                }
            }

            if (halls.Count > 0)
            {
                string currentHall = $"{halls.Dequeue()} -> ";
                int currentCapacity = capacity;

                while  (guests.Count > 0)
                {
                    int guestGroup = guests.Dequeue();

                    if (currentCapacity - guestGroup < 0)
                    {
                        currentHall = currentHall.Substring(0, currentHall.Length - 2);
                        Console.WriteLine(currentHall);
                        if (halls.Count == 0)
                        {
                            break;
                        }
                        currentCapacity = capacity;
                        currentHall = $"{halls.Dequeue()} -> ";
                    }
                  
                    currentCapacity -= guestGroup;
                    currentHall += $"{guestGroup}, ";
                }
            }
        }
    }
}
