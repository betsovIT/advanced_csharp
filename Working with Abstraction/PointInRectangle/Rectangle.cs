using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public class Rectangle
    {
        public Point LowerLeft { get; set; }
        public Point TopRight { get; set; }

        public Rectangle(Point lowerLeft, Point topRight)
        {
            LowerLeft = lowerLeft;
            TopRight = topRight;
        }
        public bool Contains(Point point)
        {
            bool insideByX = point.CoordinateX >= LowerLeft.CoordinateX 
                                && point.CoordinateX <= TopRight.CoordinateX;

            bool insideByY = point.CoordinateY >= LowerLeft.CoordinateY 
                                && point.CoordinateY <= TopRight.CoordinateY;

            return insideByX && insideByY;
        }
    }
}
