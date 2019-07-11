using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    interface ILieutenantGeneral : IPrivate
    {
        List<IPrivate> Privates { get; set; }
    }
}
