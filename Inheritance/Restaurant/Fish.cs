using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Fish : MainDish
    {
        public decimal FishGrams { get; set; }

        public Fish(string name, decimal price, double grams)
            :base(name,price,grams)
        {
            FishGrams = 22;
        }
    }
}
