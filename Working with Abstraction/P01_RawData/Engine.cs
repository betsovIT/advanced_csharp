﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
    }
}