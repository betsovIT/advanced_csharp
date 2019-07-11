using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    interface IPrivate : ISoldier
    {
        decimal Salary { get; set; }
    }
}
