using System;
using System.Collections.Generic;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaDeNumeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach (int numero in listaDeNumeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();
            Console.WriteLine("Tamanho da lista: " + listaDeNumeros.Count);

            Console.WriteLine();
            Console.Write("Adicione outro número na lista: ");
            int numeroAdicionado = int.Parse(Console.ReadLine());
            listaDeNumeros.Add(numeroAdicionado);

            Console.WriteLine();
            foreach (int numero in listaDeNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("Tamanho da lista: " + listaDeNumeros.Count);
        }
    }
}
