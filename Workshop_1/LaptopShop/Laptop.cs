using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop
{
    class Laptop
    {

        public Laptop(
            string make,
            string model,
            double displaySize,
            decimal price,
            int ram,
            int ssd)
        {
            this.Make = make;
            this.Model = model;
            this.DisplaySize = displaySize;
            this.Price = price;
            this.Ram = ram;
            this.Ssd = ssd;
        }
        public string Make { get; set; }

        public string Model { get; set; }

        public double DisplaySize { get; set; }

        public decimal Price { get; set; }

        public int Ram { get; set; }

        public int? Ssd { get; set; }

        public string FullInfo()
        {
            return $@"Make: {this.Make}, Model {this.Model}, Price {this.Price:F2}";
        }
        //Laptop
        //-Make
        //-Model
        //-Display Size
        //-Price
        //-RAM
        //-SSD
    }
}
