using System;
using System.Collections.Generic;

namespace ClubParty2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Stack<string> input = new Stack<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Queue<string> halls = new Queue<string>();
            Queue<int> guests = new Queue<int>();

            int currentCapacity = capacity;
            var listOfGuests = new List<int>();
            string currentHall = string.Empty;

            while (input.Count > 0)
            {
                string entrie = input.Pop();

                if (Char.IsLetter(entrie[0]))
                {
                    halls.Enqueue(entrie);
                }

                if (Char.IsDigit(entrie[0]) && (halls.Count > 0 || currentHall != string.Empty))
                {

                    if (currentHall == string.Empty)
                    {
                        currentHall = halls.Dequeue();
                    }

                    int group = int.Parse(entrie);

                    if (currentCapacity - group < 0)
                    {
                        Console.WriteLine($"{currentHall} -> {string.Join(", ", listOfGuests)}");
                        currentHall = string.Empty;
                        currentCapacity = capacity;
                        listOfGuests = new List<int>();

                        if (halls.Count == 0 && currentHall == string.Empty)
                        {
                            break;
                        }
                    }


                    if (group<=capacity)
                    {
                        listOfGuests.Add(group);
                        currentCapacity -= group;
                    }
                    
                }

                
            }
        }
    }
}
