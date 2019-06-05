using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> Members { get; private set; }
        public Family()
        {
            this.Members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.Members.Find(n => n.Age == Members.Max(p => p.Age));
        }
    }
}
