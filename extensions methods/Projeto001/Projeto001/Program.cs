using Projeto001.Extensions;
using System;
using System.Collections.Generic;

namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listadInteiros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List<int> listaFiltrada = listadInteiros.FiltrarPares();

            Console.WriteLine("LISTA ORIGINAL:");
            foreach (int item in listadInteiros)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("LISTA FILTRADA:");
            foreach (int i in listaFiltrada)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();   
        }
    }
}
