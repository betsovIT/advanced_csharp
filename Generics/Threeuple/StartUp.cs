using System;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstinput = Console.ReadLine().Split();
            string name = firstinput[0] + " " + firstinput[1];
            string address = firstinput[2];
            string town = firstinput[3];
            var firstTuple = new MyTuple<string, string, string>(name, address, town);
            Console.WriteLine(firstTuple.ToString());

            string[] secondInput = Console.ReadLine().Split();
            string nameOfDrinker = secondInput[0];
            int liters = int.Parse(secondInput[1]);
            bool drunk = false;
            if (secondInput[2] == "drunk")
            {
                drunk = true;
            }
            var secondTuple = new MyTuple<string, int,bool>(nameOfDrinker, liters,drunk);
            Console.WriteLine(secondTuple.ToString());

            string[] thirdInput = Console.ReadLine().Split();
            string nameOfAccountHolder = thirdInput[0];
            double balance = double.Parse(thirdInput[1]);
            string bank = thirdInput[2];
            var thirdTuple = new MyTuple<string,double,string>(nameOfAccountHolder,balance,bank);
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
