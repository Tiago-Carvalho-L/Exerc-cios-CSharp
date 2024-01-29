using System;
using System.Collections.Generic;
using Projeto002.Entities;

namespace ProjetoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaLista<string> minhaLista = new MinhaLista<string>(new List<string>());

            Console.Write("Quantos itens você quer adicionar na lista? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}° item: ");
                string item = Console.ReadLine();
                minhaLista.AdicionarItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("Gostaria de remover algum item da lista? [S/N]");
            string res = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (res == "S")
            {
                Console.Write("Quantos itens devem ser removidos? ");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Qual item de ser removido? ");
                    string itemRemover = Console.ReadLine();
                    minhaLista.RemoverItem(itemRemover);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Total de itens contidos na lista: " + minhaLista.ContarItem());
            Console.WriteLine("Itens da lista:");
            minhaLista.ObterTodosItens();
            Console.WriteLine();

        }
    }
}
