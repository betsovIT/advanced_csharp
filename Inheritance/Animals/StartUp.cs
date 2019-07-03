using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

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

                if (int.Parse(parameters[1]) < 1 || (parameters[2] != "Male" && parameters[2] != "Female"))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            animals.Add(new Dog(parameters[0], int.Parse(parameters[1]), parameters[2]));
                            break;
                        case "Cat":
                            animals.Add(new Cat(parameters[0], int.Parse(parameters[1]), parameters[2]));
                            break;
                        case "Frog":
                            animals.Add(new Frog(parameters[0], int.Parse(parameters[1]), parameters[2]));
                            break;
                        case "Kitten":
                            animals.Add(new Kitten(parameters[0], int.Parse(parameters[1]), parameters[2]));
                            break;
                        case "Tomcat":
                            animals.Add(new Tomcat(parameters[0], int.Parse(parameters[1]), parameters[2]));
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ae)
                {

                    Console.WriteLine(ae.Message);
                }
                
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }
    }
}
