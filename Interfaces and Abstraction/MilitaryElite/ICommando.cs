using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    interface ICommando : ISpecialistSoldier
    {
        List<Mission> Missions { get; set; }
    }
}
