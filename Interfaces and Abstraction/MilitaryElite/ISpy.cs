using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    interface ISpy : ISoldier
    {
        int CodeNumber { get; set; }
    }
}
