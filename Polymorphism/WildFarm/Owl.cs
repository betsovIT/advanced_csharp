using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
        {
            this.Name = name;
            this.Weight = weight;
            this.WingSize = wingSize;
        }

        public override string AskForFood()
        {
            return "Hoot Hoot";
        }

        public override void Feed(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                this.Weight += 0.25 * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
