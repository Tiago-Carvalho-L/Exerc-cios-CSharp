using System;
using System.Collections.Generic;

namespace ExercicioSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Console.Write("Digite o tamanho da Lista: ");
            int tamanho = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamanho; i++)
            {
                numeros.Add(i);
            }

            Console.WriteLine();
            Console.WriteLine("LISTA:");
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.Remove(2);
            Console.WriteLine();
            Console.WriteLine("Lista sem o número 2: ");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.RemoveAll(x => x % 2 == 0);
            Console.WriteLine();
            Console.WriteLine("Lista sem os números pares: ");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.RemoveAt(3);
            Console.WriteLine();
            Console.WriteLine("Lista sem o 3 elemento: ");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.RemoveRange(0, 2);
            Console.WriteLine();
            Console.WriteLine("Lista sem os dois primeiros elementos: ");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
