using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    class People
    {
        public Dictionary<string,Person> Roster { get; set; }

        public People()
        {
            this.Roster = new Dictionary<string, Person>();
        }
    }
}
