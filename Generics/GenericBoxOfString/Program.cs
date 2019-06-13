using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                var box = new Box<string>(input);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
