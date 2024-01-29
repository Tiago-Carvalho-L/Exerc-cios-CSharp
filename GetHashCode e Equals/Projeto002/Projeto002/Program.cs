using System;
using Projeto002.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ProjetoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Console.WriteLine("Insira as informações de dois produtos: ");
            Console.WriteLine();
            int quantidadeProdutos = 2;

            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos.Add(new Produto(id, nome, preco));
                Console.WriteLine();
            }

            Console.WriteLine(produtos[0].Equals(produtos[1]));
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.GetHashCode());
            }

        }
    }
}
