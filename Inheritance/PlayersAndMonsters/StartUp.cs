using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var pesho = new DarkKnight("pesho", 12);

            Console.WriteLine(pesho);
        }
    }
}
