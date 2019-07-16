using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get => this.width;
            private set => this.width = value;
        }
        public double Height
        {
            get => this.height;
            private set => this.height = value;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return Width * 2 + Height * 2;
        }

        public override string Draw()
        {
            return base.Draw() + " Rectangle";
        }
    }
}
