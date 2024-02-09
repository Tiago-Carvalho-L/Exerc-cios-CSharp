using System;
using System.Collections.Generic;

namespace ProjetoTres
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>() { "ana", "Misericórdio", "Trintino", "sal", "Ame", "Mingue" };

            List<string> nomeLetraMaiuscula = nomes.FindAll(LetraMaiuscula);

            Console.WriteLine("LISTA ORIGINAL:");
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine();

            Console.WriteLine("NOMES QUE COMEÇAM COM LETRA MAIUSCULA:");
            foreach (string nome in nomeLetraMaiuscula)
            {
                Console.WriteLine(nome);
            }
        }

        public static bool LetraMaiuscula(String nome)
        {
            string primeiraLetra = nome.Substring(0, 1);
            if (primeiraLetra == primeiraLetra.ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
