using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    interface IEngineer : ISpecialistSoldier
    {
        List<Repair> Repairs { get; set; }
    }
}
