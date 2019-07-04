using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Tomcat : Cat
    {
        const string TomcatGender = "Male";
        public Tomcat(string name, int age, string gender)
            : base(name, age, TomcatGender)
        {
            
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
