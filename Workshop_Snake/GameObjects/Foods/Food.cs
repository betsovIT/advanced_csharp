using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    public abstract class Food : Point
    {
        private Wall wall;
        private char foodSymbol;
        private Random random;

        public Food(Wall wall , char foodSymbol, int points)
            : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            this.FoodPoints = points;
            this.foodSymbol = foodSymbol;
            this.random = new Random();

        }

        public int FoodPoints { get; private set; }

        public bool IsFoodPoint(Point snakeHead)
        {
            return snakeHead.TopY == this.TopY && snakeHead.LeftX == this.LeftX;
        }

        public void SetRandomPosition(Queue<Point> snakeElements)
        {
            this.LeftX = this.random.Next(2, this.LeftX - 2);
            this.TopY = this.random.Next(2, this.TopY - 2);

            bool isPointOnSnake = snakeElements.Any(p => p.LeftX == this.LeftX && p.TopY == this.TopY);

            while (isPointOnSnake)
            {
                this.LeftX = this.random.Next(2, this.LeftX - 2);
                this.TopY = this.random.Next(2, this.TopY - 2);

                isPointOnSnake = snakeElements.Any(p => p.LeftX == this.LeftX && p.TopY == this.TopY);
            }

            Console.BackgroundColor = ConsoleColor.Red;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
