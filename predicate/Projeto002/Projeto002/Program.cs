using System;
using System.Collections.Generic;

namespace ProjetoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 1, 3, 4, 5, 2};

            List<int> numeroPar = lista.FindAll(NumeroPar);

            Console.WriteLine(Resultado(numeroPar));
        }

        public static bool NumeroPar(int numero)
        {
            return numero % 2 == 0;
        }

        public static string Resultado(List<int> lista)
        {
            if (lista.Count != 0)
            {
                return "A lista contém número(s) par(es)";
            }
            else
            {
                return "A lista não contém número(s) par(es)";
            }
        }
    }
}
