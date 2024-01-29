using System.Collections.Generic;

namespace Projeto002.Services
{
    class Conjunto
    {
        public static void PrintCollection<T>(IEnumerable<T> collection1, IEnumerable<T> collection2)
        {
            HashSet<T> set1 = new HashSet<T>(collection1);
            set1.UnionWith(collection2);

            HashSet<T> set2 = new HashSet<T>(collection1);
            set2.IntersectWith(collection2);

            HashSet<T> set3 = new HashSet<T>(collection1);
            set3.ExceptWith(collection2);

            Console.WriteLine();
            Console.WriteLine("Union:");
            foreach (T item in set1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Intersect:");
            foreach (T item in set2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Except:");
            foreach (T item in set3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
