using CommandPattern.Core;
using System;

namespace CommandPattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var commandInterpreter = new CommandInterpreter();
            var engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
