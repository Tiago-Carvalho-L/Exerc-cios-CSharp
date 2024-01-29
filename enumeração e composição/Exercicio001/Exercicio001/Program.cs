using Exercicio001.Entities;
using Exercicio001.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PEDIDOS: ");
            Console.WriteLine();
            Console.Write("ID do pedido: ");
            int idPedido = int.Parse(Console.ReadLine());
            Console.Write("Status do pedido: ");
            StatusPedido statusPedido = Enum.Parse<StatusPedido>(Console.ReadLine());
            Pedido pedido = new Pedido(idPedido, statusPedido);
            Console.Write("Quantos pedidos serão realizados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Produto #{i+1}:");
                Console.Write("ID: ");
                int idProduto = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());

                Produto produto = new Produto(idProduto, nomeProduto, precoProduto);
                PedidoItem item = new PedidoItem(produto, quantidadeProduto);

                pedido.AddPedido(item);
            }

            Console.WriteLine();
            Console.WriteLine(pedido);
        }
    }
}