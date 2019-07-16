using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        public Animal(string name, string favFood)
        {
            Name = name;
            FavouriteFood = favFood;
        }

        public virtual string ExplainSelf()
        {
           return "I am animal.";
        }


    }
}
