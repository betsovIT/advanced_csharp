using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> iterator = new ListyIterator<string>(); 

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] commandLine = input.Split();
                string command = commandLine[0];

                try
                {
                    if (command == "Create")
                    {
                        iterator.Create(commandLine.Skip(1).ToList());
                    }
                    else if (command == "Move")
                    {
                        Console.WriteLine(iterator.Move());
                    }
                    else if (command == "Print")
                    {
                        iterator.Print();
                    }
                    else if (command == "HasNext")
                    {
                        Console.WriteLine(iterator.HasNext());
                    }
                    else if (command == "PrintAll")
                    {
                        foreach (var item in iterator)
                        {
                            Console.Write(item+' ');
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
