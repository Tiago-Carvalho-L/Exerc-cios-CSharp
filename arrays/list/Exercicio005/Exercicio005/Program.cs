using System;
using System.Collections.Generic;

namespace ExercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>();

            string resposta = "s";

            while (resposta == "s" || resposta == "S")
            {
                Console.Write("Adicione um nome na lista: ");
                string nome = Console.ReadLine();
                listaDeNomes.Add(nome);
                Console.WriteLine();
                Console.Write("Quer adicionar outro nome na lista? [s/n] ");
                resposta = Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("LISTA NOMES");
            foreach (string nome in listaDeNomes)
            {
                Console.WriteLine(nome);
            }

            List<string> listaDeNomes2 = listaDeNomes.FindAll(x => x.Length > 5);

            Console.WriteLine();
            Console.WriteLine("     LISTA NOMES      ");
            Console.WriteLine("[com mais de 5 letras]");
            foreach (string nome in listaDeNomes2)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
