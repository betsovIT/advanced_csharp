using System;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var col1 = new AddColection();
            var col2 = new AddRemoveCollection();
            var col3 = new MyList();

            string[] strs = Console.ReadLine().Split();
            int removeOps = int.Parse(Console.ReadLine());

            for (int i = 0; i < strs.Length; i++)
            {
                Console.Write(col1.Add(strs[i]).ToString() + ' ');
            }
            Console.WriteLine();

            for (int i = 0; i < strs.Length; i++)
            {
                Console.Write(col2.Add(strs[i]).ToString() + ' ');
            }
            Console.WriteLine();

            for (int i = 0; i < strs.Length; i++)
            {
                Console.Write(col3.Add(strs[i]).ToString() + ' ');
            }
            Console.WriteLine();

            for (int i = 0; i < removeOps; i++)
            {
                Console.Write(col2.Remove() + ' ');
            }
            Console.WriteLine();

            for (int i = 0; i < removeOps; i++)
            {
                Console.Write(col3.Remove() + ' ');
            }
            Console.WriteLine();
        }
    }
}
