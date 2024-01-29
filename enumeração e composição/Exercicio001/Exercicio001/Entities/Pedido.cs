using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Exercicio001.Entities.Enums;

namespace Exercicio001.Entities
{
    class Pedido
    {
        public int Id { get; set; }
        public StatusPedido Status { get; set; }
        public List<PedidoItem> Pedidos { get; set; } = new List<PedidoItem>();

        public Pedido()
        {

        }

        public Pedido(int id, StatusPedido status)
        {
            Id = id;
            Status = status;
        }

        public void AddPedido(PedidoItem pedido)
        {
            Pedidos.Add(pedido);
        }

        public void RemovePedido(PedidoItem pedido)
        {
            Pedidos.Remove(pedido);
        }

        public double ValorTotal()
        {
            double sum = 0.0;
            foreach (PedidoItem item in Pedidos)
            {
                sum += item.Quantida * item.Produto.Preco;
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Pedidos: ");
            foreach (PedidoItem item in Pedidos)
            {
                sb.AppendLine("Nome: " + item.Produto.Nome + ", Quantidade: " + item.Quantida + ", Preço: $" + item.Produto.Preco.ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.AppendLine("Valor Total: " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
