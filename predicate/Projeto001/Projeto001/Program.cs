using System;
using System.Collections.Generic;

namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosInteiros = new List<int>() { 1, 3, 4, 5, 2};

            List<int> numerosPares = numerosInteiros.FindAll(NumeroPar);

            Console.WriteLine("Lista original:");
            foreach (int i in numerosInteiros)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Lista filtrada:");
            foreach (int i in numerosPares)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static bool NumeroPar(int i)
        {
            return i % 2 == 0;
        }
    }
}