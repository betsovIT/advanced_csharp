using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char wallSymbol = '\u25A0';
        public Wall(int leftX, int topY)
            : base(leftX, topY)
        {
            this.InitializeWallBorders();
        }

        public bool IsPointOfWall(Point snake)
        {
            return snake.LeftX == 0 || snake.LeftX == this.LeftX - 1 || snake.TopY == 0 || snake.TopY == this.TopY;
        }

        private void InitializeWallBorders()
        {
            this.SetHorizontalLine(0);
            this.SetHorizontalLine(this.TopY);
            this.SetVerticalLine(0);
            this.SetVerticalLine(this.LeftX - 1);
        }

        private void SetHorizontalLine(int topY)
        {
            for (int i = 0; i < LeftX; i++)
            {
                this.Draw(i, topY, wallSymbol);
            }
        }

        private void SetVerticalLine(int leftX)
        {
            for (int i = 0; i < TopY; i++)
            {
                this.Draw(leftX, i, wallSymbol);
            }
        }
    }
}
