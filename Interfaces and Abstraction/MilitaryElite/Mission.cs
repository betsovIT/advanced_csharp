using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    class Mission
    {
        public string CodeName { get; set; }
        public string State { get; set; }

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
