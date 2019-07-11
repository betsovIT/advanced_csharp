using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    interface IBuyer
    {
        int Food { get; set; }
        void BuyFood();
    }
}
