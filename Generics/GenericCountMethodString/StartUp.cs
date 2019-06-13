using System;

namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var list = new GenericList<string>();

            for (int i = 0; i < lines; i++)
            {
                list.Add(Console.ReadLine());
            }

            string itemToCompare = Console.ReadLine();

            Console.WriteLine(list.GetCountOfGreaterElements(itemToCompare));
        }
    }
}
