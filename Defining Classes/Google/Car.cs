﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }
    }
}
