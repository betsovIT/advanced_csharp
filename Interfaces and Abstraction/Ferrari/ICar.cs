using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    interface ICar
    {
        string Model { get; set; }
        string Driver { get; set; }

        string PressTheGass();

        string Brake();

    }
}
