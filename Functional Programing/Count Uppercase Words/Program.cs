using System;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];
            foreach (string word in text)
            {
                if (checker(word))
                {
                    Console.WriteLine(word);
                }
            }
            
        }
    }
}
