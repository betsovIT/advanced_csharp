using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split();

                if (input[0] == "Beast!")
                {
                    break;
                }

                string animalType = input[0];
                string[] parameters = Console.ReadLine()
                    .Split();

                //if (int.Parse(parameters[1]) < 1 || (parameters[2] != "Male" && parameters[2] != "Female"))
                //{
                //    sb.AppendLine("Invalid input!");
                //    continue;
                //}

                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            sb.AppendLine(new Dog(parameters[0], int.Parse(parameters[1]), parameters[2]).ToString());
                            break;
                        case "Cat":
                            sb.AppendLine(new Cat(parameters[0], int.Parse(parameters[1]), parameters[2]).ToString());
                            break;
                        case "Frog":
                            sb.AppendLine(new Frog(parameters[0], int.Parse(parameters[1]), parameters[2]).ToString());
                            break;
                        case "Kitten":
                            sb.AppendLine(new Kitten(parameters[0], int.Parse(parameters[1]), parameters[2]).ToString());
                            break;
                        case "Tomcat":
                            sb.AppendLine(new Tomcat(parameters[0], int.Parse(parameters[1]), parameters[2]).ToString());
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ae)
                {

                    sb.AppendLine(ae.Message);
                }                
            }

            Console.WriteLine(sb.ToString());

            
        }
    }
}
