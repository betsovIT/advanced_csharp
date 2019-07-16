using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            while (true)
            {
                string[] animalInput = Console.ReadLine().Split();
                if (animalInput[0] == "End")
                {
                    break;
                }

                string[] foodInput = Console.ReadLine().Split();

                Animal animal = null;
                Food food = null;

                string type = animalInput[0];
                string name = animalInput[1];
                double weight = double.Parse(animalInput[2]);

                switch (type)
                {
                    case "Owl":                        
                        animal = new Owl(name, weight, double.Parse(animalInput[3]));
                        break;
                    case "Hen":                        
                        animal = new Hen(name, weight, double.Parse(animalInput[3]));
                        break;
                    case "Mouse":
                        animal = new Mouse(name, weight, animalInput[3]);
                        break;
                    case "Dog":
                        animal = new Dog(name, weight, animalInput[3]);
                        break;
                    case "Cat":
                        animal = new Cat(name, weight, animalInput[3],animalInput[4]);
                        break;
                    case "Tiger":
                        animal = new Tiger(name, weight, animalInput[3], animalInput[4]);
                        break;
                    default:
                        break;
                }

                string foodType = foodInput[0];
                int foodQuantity = int.Parse(foodInput[1]);

                switch (foodType)
                {
                    case "Fruit":
                        food = new Fruit(foodQuantity);
                        break;
                    case "Vegetable":
                        food = new Vegetable(foodQuantity);
                        break;
                    case "Meat":
                        food = new Meat(foodQuantity);
                        break;
                    case "Seeds":
                        food = new Seeds(foodQuantity);
                        break;
                    default:
                        break;
                }

                Console.WriteLine(animal.AskForFood());
                animal.Feed(food);

                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
