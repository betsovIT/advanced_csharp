using System;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            var text = new List<char>();

            var commands = new Queue<string[]>();

            for (int i = 0; i < commandCount; i++)
            {
                commands.Enqueue(Console.ReadLine().Split());
            }

            var executedCommands = new Stack<string[]>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] command = commands.Dequeue();
                string action = command[0];

                if (action == "1")
                {
                    string arguments = command[1];

                    for (int j = 0; j < arguments.Length; j++)
                    {
                        text.Add(arguments[j]);
                    }

                    executedCommands.Push(command);
                }
                else if (action == "2")
                {
                    int arguments = int.Parse(command[1]);
                    string toStore = string.Empty;

                    for (int j = 0; j < arguments; j++)
                    {
                        toStore += text[text.Count - 1];
                        text.RemoveAt(text.Count - 1);
                    }

                    executedCommands.Push(new string[2] { "2", toStore });
                }
                else if (action == "3")
                {
                    int arguments = int.Parse(command[1]);

                    Console.WriteLine(text[arguments - 1]);
                }
                else if (action == "4")
                {
                    string[] toUndo = executedCommands.Pop();
                    int commandToUndo = int.Parse(toUndo[0]);
                    string arguments = toUndo[1];

                    if (commandToUndo == 1)
                    {
                        for (int j = 0; j < arguments.Length; j++)
                        {
                            text.RemoveAt(text.Count - 1);
                        }
                    }
                    else if (commandToUndo == 2)
                    {
                        for (int j = arguments.Length - 1; j >= 0; j--)
                        {
                            text.Add(arguments[j]);
                        }
                    }
                }
            }
        }
    }
}
