using System;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> myCollection = new MyStack<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] commandLine = input.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                string command = commandLine[0];

                try
                {
                    if (command == "Push")
                    {
                        for (int i = 1; i < commandLine.Length; i++)
                        {
                            myCollection.Push(commandLine[i]);
                        }
                    }
                    else if (command == "Pop")
                    {
                        myCollection.Pop();
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }

            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }
            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
