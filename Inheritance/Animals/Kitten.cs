using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age, string gender)
            : base(name, age, gender)
        {
            base.gender = "Female";
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
