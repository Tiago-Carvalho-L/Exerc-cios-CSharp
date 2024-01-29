using System;
using System.Collections.Generic;

namespace ExericioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaDeNumeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int primeiroPar = listaDeNumeros.Find(x => x % 2 == 0);

            foreach (int numero in listaDeNumeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();
            Console.WriteLine($"O primeiro número para da lista é o {primeiroPar}");
        }
    }
}