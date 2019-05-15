using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int pricePerBullet = int.Parse(Console.ReadLine());
            int magazineSize = int.Parse(Console.ReadLine());
            var bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int inteligence = int.Parse(Console.ReadLine());

            int bulletCounter = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int bullet = bullets.Pop();
                int safeLock = locks.Peek();
                                
                if (bullet > safeLock)
                {
                    Console.WriteLine("Ping!");
                }
                else
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }

                bulletCounter++;

                if (bulletCounter == magazineSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    bulletCounter = 0;
                }

                inteligence -= pricePerBullet;

            }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else if (bullets.Count >= 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${inteligence}");
            }
        }
    }
}
