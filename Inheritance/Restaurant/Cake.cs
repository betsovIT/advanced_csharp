using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Cake : Dessert
    {
        public double CakeGrams { get; set; }
        public double CakeCalories { get; set; }
        public decimal CakePrice { get; set; }

        public Cake(string name, decimal price, double grams, double calories)
            :base(name,price,grams, calories)
        {
            CakeGrams = 250;
            CakeCalories = 1000;
            CakePrice = 5m;
        }
    }
}
