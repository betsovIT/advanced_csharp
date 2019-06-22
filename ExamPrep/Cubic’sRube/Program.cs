using System;

namespace Cubic_sRube
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,,] cube = new int[size, size, size];
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Analyze")
                {
                    break;
                }

                int xCoordinate = int.Parse(input.Split()[0]);
                int yCoordinate = int.Parse(input.Split()[1]);
                int zCoordinate = int.Parse(input.Split()[2]);
                int value = int.Parse(input.Split()[3]);

                if (AreValidCoordinates(xCoordinate,yCoordinate,zCoordinate,cube))
                {
                    cube[xCoordinate, yCoordinate, zCoordinate] = value;
                }
            }

            int emptySum = 0;
            int filledSum = 0;

            foreach (int cell in cube)
            {
                filledSum += cell;
                if (cell == 0)
                {
                    emptySum++;
                }
            }

            Console.WriteLine(filledSum);
            Console.WriteLine(emptySum);
        }

        static bool AreValidCoordinates(int x, int y, int z, int[,,] cube)
        {
            if (x < 0 || x >= cube.GetLength(0))
            {
                return false;
            }

            if (y < 0 || y >= cube.GetLength(1))
            {
                return false;
            }

            if (z < 0 || z >= cube.GetLength(2))
            {
                return false;
            }

            return true;
        }
    }
}
