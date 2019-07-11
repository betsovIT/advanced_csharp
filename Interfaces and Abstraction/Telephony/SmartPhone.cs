using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Telephony
{
    class SmartPhone : ICallMaker, IBrowser
    {
        public void Browse(string website)
        {
            var regex = new Regex(@"^\D*$");

            if (regex.IsMatch(website))
            {
                Console.WriteLine($"Browsing: {website}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }

        public void Call(string number)
        {
            var regex = new Regex(@"^\d+$");

            if (regex.IsMatch(number))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
