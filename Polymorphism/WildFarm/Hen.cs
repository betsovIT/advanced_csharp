using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
        {
            this.Name = name;
            this.Weight = weight;
            this.WingSize = wingSize;
        }

        public override string AskForFood()
        {
            return "Cluck";
        }

        public override void Feed(Food food)
        {
            this.Weight += 0.35 * food.Quantity;
            this.FoodEaten += food.Quantity;
        }
    }
}
