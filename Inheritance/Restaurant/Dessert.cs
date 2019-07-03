using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Dessert : Food
    {
        public double Calories { get; set; }
        public Dessert(string name, decimal price, double grams, double caolories)
            :base(name,price,grams)
        {
            Calories = caolories;
        }
    }
}
