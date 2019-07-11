using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    interface IPerson
    {
        string Name { get; set; }
        string Country { get; set; }
         int Age { get; set; }

        string GetName();
    }
}
