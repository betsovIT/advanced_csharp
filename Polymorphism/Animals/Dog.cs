using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string name, string favFood)
            : base(name, favFood)
        {

        }

        public override string ExplainSelf()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"I am {Name} and my favourite food is {FavouriteFood}");
            sb.AppendLine("DJAAF");

            return sb.ToString().TrimEnd();
        }
    }
}
