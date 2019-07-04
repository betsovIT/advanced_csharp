using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Kitten : Cat
    {
        const string KittenGender = "Female";
        public Kitten(string name, int age, string gender)
            : base(name, age, KittenGender)
        {
            
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
