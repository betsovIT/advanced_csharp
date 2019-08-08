using MXGP.Core.Contracts;
using MXGP.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Core
{
    public class Engine
    {
        private ChampionshipController controller;
        private ConsoleReader reader;
        private ConsoleWriter writer;
        private CommandInterpreter interpreter;

        public Engine()
        {
            controller = new ChampionshipController();
            reader = new ConsoleReader();
            writer = new ConsoleWriter();
            interpreter = new CommandInterpreter(controller);
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string command = reader.ReadLine();
                    string output = interpreter.ExecuteCommand(command);
                    writer.WriteLine(output);
                }
                catch (Exception e)
                {
                    writer.WriteLine(e.Message);                 
                }
            }
        }
    }
}
