using System;
using System.Collections.Generic;

namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>() { 1, 2, 3, 4, 5};
            HashSet<int> b = new HashSet<int>() { 4, 5, 6, 7, 8 };

            //Union
            Console.WriteLine("Union:");
            HashSet<int> c = new HashSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);
            Console.WriteLine();

            //Intersect
            Console.WriteLine("Intersect:");
            HashSet<int> d = new HashSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);
            Console.WriteLine();

            //Except
            Console.WriteLine("Except:");
            HashSet<int> e = new HashSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
            Console.WriteLine();
        }

        static void PrintCollection<T> (IEnumerable<T> set)
        {
            foreach (T item in set)
            {
                Console.Write(item + " "); 
            }
            Console.WriteLine();
        }
    }
}
