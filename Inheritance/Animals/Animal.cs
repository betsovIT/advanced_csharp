using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animal
    {
        protected string name;
        protected int age;
        protected string gender;
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    this.age = value;
                }                
            }
        }
        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.gender = value;
            }
        }

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual void ProduceSound()
        {
            Console.WriteLine("I am mute");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} \n{this.Name} {this.age} {this.gender}";
        }
    }
}
