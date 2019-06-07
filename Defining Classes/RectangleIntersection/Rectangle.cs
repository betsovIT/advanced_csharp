using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleIntersection
{
    class Rectangle
    {
        public string Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Rectangle(string id, int width, int heigth, int x, int y)
        {
            this.Id = id;
            this.Width = width;
            this.Height = heigth;
            this.X = x;
            this.Y = y;
        }

        public bool IsColiding(Rectangle rectangle)
        {
            //Defining borders
            int minX = X;
            int maxX = X + Width;
            int maxY = Y;
            int minY = Y - Height;

            //Second rectangle vertex coordinates

            int secondTriangleX1 = rectangle.X;
            int secondTriangleY1 = rectangle.Y;

            int secondTriangleX2 = rectangle.X + rectangle.Width;
            int secondTriangleY2 = rectangle.Y;

            int secondTriangleX3 = rectangle.X;
            int secondTriangleY3 = rectangle.Y - rectangle.Height;

            int secondTriangleX4 = rectangle.X + rectangle.Width;
            int secondTriangleY4 = rectangle.Y - rectangle.Height;

            //Conditions determening if a vertex of the second rectangle falls into the area of the first

            if (secondTriangleX1 >= minX && secondTriangleX1 <= maxX)
            {
                if (secondTriangleY1 >= minY && secondTriangleY1 <= maxY)
                {
                    return true;
                }
            }

            if (secondTriangleX2 >= minX && secondTriangleX2 <= maxX)
            {
                if (secondTriangleY2 >= minY && secondTriangleY2 <= maxY)
                {
                    return true;
                }
            }

            if (secondTriangleX3 >= minX && secondTriangleX3 <= maxX)
            {
                if (secondTriangleY3 >= minY && secondTriangleY3 <= maxY)
                {
                    return true;
                }
            }

            if (secondTriangleX4 >= minX && secondTriangleX4 <= maxX)
            {
                if (secondTriangleY4 >= minY && secondTriangleY4 <= maxY)
                {
                    return true;
                }
            }


            return false;
        }
    }
}
