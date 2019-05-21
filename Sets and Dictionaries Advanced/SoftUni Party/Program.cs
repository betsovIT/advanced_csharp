using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var invitedVIPs = new HashSet<string>();
            var invitedRegulars = new HashSet<string>();

            //Filling the sets with reservation numbers
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }

                if (char.IsDigit(input[0]))
                {
                    invitedVIPs.Add(input);
                }
                else
                {
                    invitedRegulars.Add(input);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                invitedRegulars.Remove(input);
                invitedVIPs.Remove(input);
            }

            Console.WriteLine(invitedVIPs.Count + invitedRegulars.Count);
            foreach (var invitation in invitedVIPs)
            {
                Console.WriteLine(invitation);
            }
            foreach (var invitation in invitedRegulars)
            {
                Console.WriteLine(invitation);
            }
        }
    }
}
