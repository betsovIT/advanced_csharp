using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    interface ISpecialistSoldier : IPrivate
    {
        string Corps { get; set; }
    }
}
