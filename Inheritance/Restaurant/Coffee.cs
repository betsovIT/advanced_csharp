using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Coffee : HotBeverage
    {
        const double CoffeeMilliliters = 50.0;
        const decimal CoffeePrice = 3.5m;
        public double Caffeine { get; set; }

        public Coffee(string name,  double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }
    }
}
