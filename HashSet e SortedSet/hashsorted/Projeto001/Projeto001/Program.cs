using System;
using System.Collections.Generic;
using Projeto001.Entities;

namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Conjunto conjunto = new Conjunto();

            try
            {
                Console.WriteLine("CONJUNTO DE INTEIROS:");
                Console.Write("Quantos elementos você quer adicionar no conjunto? ");
                int quantidadeElementos = int.Parse(Console.ReadLine());

                Console.Write("Digite os elementos separados por um espaço: ");
                string[] vet = Console.ReadLine().Split(' ');
                conjunto.AdicionarElementos(quantidadeElementos, vet);

                Console.WriteLine();
                conjunto.MostrarColecao();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
