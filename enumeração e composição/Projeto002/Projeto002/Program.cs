using Projeto002.Entities;
using Projeto002.Entities.Enums;
using System;
using System.Globalization;

namespace ProjetoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número do pedido: ");
            int numeroPedido = int.Parse(Console.ReadLine());
            Console.Write("Data do pedido: ");
            DateTime dataPedido = DateTime.Now;
            Console.Write("Status do pedido [EmAndamento | Concluido | Cancelado]: ");
            StatusPedido statusPedido = Enum.Parse<StatusPedido>(Console.ReadLine());

            Pedido pedido = new Pedido(numeroPedido, dataPedido, statusPedido);

            Console.WriteLine();
            Console.Write("Quantos itens foram pedidos: ");
            int quantidadeItens = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantidadeItens; i++)
            {
                Console.WriteLine($"Pedido #{i}:");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());
                Produto produto = new Produto(nomeProduto, precoProduto);
                ItemPedido itemPedido = new ItemPedido(produto, quantidadeProduto);
                pedido.AdicionarItem(itemPedido);
            }

            Console.WriteLine();
            Console.WriteLine("Valor total da compra: ");
            Console.WriteLine(pedido.CalcularTotal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
