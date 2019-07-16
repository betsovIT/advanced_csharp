using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
        {
            this.Name = name;
            this.Weight = weight;
            this.LivingRegion = livingRegion;
        }
        public override string AskForFood()
        {
            return "Squeak";
        }

        public override void Feed(Food food)
        {
            if (food.GetType().Name == "Fruit" || food.GetType().Name == "Vegetable")
            {
                this.Weight += 0.1 * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
