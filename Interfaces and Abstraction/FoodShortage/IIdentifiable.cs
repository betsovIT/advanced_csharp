using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IIdentifiable
    {
        string Id { get; set; }

        bool CheckIfFake(string lastDigits);
    }
}
