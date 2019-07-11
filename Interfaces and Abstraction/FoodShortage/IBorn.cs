using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    interface IBorn
    {
        string Birthdate { get; set; }

        bool CheckBirthdate(string year);
    }
}
