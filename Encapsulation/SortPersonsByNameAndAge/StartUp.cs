using System;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                var person = new Person(firstName, lastName, age);

                Console.WriteLine(person.ToString());
            }
        }
    }
}
