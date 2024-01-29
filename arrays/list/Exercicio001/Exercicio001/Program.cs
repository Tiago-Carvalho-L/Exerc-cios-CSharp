using System;
using System.Collections.Generic;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>();

            string resposta = "s";

            while (resposta == "s" || resposta == "S")
            {    
                Console.Write("Adicione um nome a lista: ");
                string nome = Console.ReadLine();
                listaDeNomes.Add(nome);
                Console.WriteLine();
                Console.Write("Deseja adicionar outro nome? [s/n]: ");
                resposta = Console.ReadLine();
                Console.Clear();
            }

            foreach(string obj in listaDeNomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.Write("Agora digite um nome e o índice em que ele será alocado na lista: ");
            string[] s = Console.ReadLine().Split(' ');
            string nome2 = s[0];
            int indice = int.Parse(s[1]);

            if (indice > listaDeNomes.Count)
            {
                Console.WriteLine("Índice inválido");
            }
            else
            {
                listaDeNomes.Insert(indice, nome2);

                Console.WriteLine();
                foreach (string obj in listaDeNomes)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }
}