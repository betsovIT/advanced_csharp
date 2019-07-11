using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        public string Model { get; set; } = "488-Spider";
        public string Driver { get ; set ; }

        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Brake()
        {
            return "Brakes!";
        }

        public string PressTheGass()
        {
            return "Gas!";
        }
    }
}
