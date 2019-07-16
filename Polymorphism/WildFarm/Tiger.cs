using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
        {
            this.Name = name;
            this.Weight = weight;
            this.LivingRegion = livingRegion;
            this.Breed = breed;
        }
        public override string AskForFood()
        {
            return "ROAR!!!";
        }

        public override void Feed(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                this.Weight += food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
