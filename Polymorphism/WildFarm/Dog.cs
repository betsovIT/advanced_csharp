using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
        {
            this.Name = name;
            this.Weight = weight;
            this.LivingRegion = livingRegion;
        }
        public override string AskForFood()
        {
            return "Woof!";
        }

        public override void Feed(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                this.Weight += 0.4 * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
