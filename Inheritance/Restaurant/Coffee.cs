using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Coffee : HotBeverage
    {
        public double CofeeMilliliters { get; set; }
        public decimal CoffeePrice { get; set; }
        public double Caffeine { get; set; }

        public Coffee(string name, decimal price, double milliliters)
            :base(name,price,milliliters)
        {
            CoffeePrice = 3.5m;
            CofeeMilliliters = 50;
        }
    }
}
