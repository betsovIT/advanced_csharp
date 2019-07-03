using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, this.Count);
            string value = this[index];
            this.RemoveAt(index);

            return value;
        }
    }
}
