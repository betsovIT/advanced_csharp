using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rectangles = new Dictionary<string, Rectangle>();
            string[] colissions = new string[parameters[1]];

            for (int i = 0; i < parameters[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                string id = input[0];
                int width = int.Parse(input[1]);
                int heigth = int.Parse(input[2]);
                int x = int.Parse(input[3]);
                int y = int.Parse(input[4]);

                rectangles.Add(input[0], new Rectangle(id, width, heigth, x, y));
            }

            for (int i = 0; i < parameters[1]; i++)
            {
                colissions[i] = Console.ReadLine();
            }

            for (int i = 0; i < colissions.Length; i++)
            {
                string firstRectangleId = colissions[i].Split()[0];
                string secondRectangleId = colissions[i].Split()[1];
                Rectangle firstRectangle = rectangles[firstRectangleId];
                Rectangle secondRectangle = rectangles[secondRectangleId];

                Console.WriteLine((firstRectangle.IsColiding(secondRectangle)).ToString().ToLower());
            }
        }
    }
}
