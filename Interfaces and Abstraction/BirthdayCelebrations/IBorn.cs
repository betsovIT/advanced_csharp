using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    interface IBorn
    {
        string Birthdate { get; set; }

        bool CheckBirthdate(string year);
    }
}
