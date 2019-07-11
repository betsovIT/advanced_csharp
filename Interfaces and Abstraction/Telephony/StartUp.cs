using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string[] websites = Console.ReadLine().Split();

            var phone = new SmartPhone();

            foreach (string number in numbers)
            {
                phone.Call(number);
            }

            foreach (string website in websites)
            {
                phone.Browse(website);
            }
        }
    }
}
