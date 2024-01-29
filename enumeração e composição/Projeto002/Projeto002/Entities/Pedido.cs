using Projeto002.Entities;
using Projeto002.Entities.Enums;
using System.Collections.Generic;

namespace Projeto002.Entities
{
    class Pedido
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        public Pedido()
        {

        }

        public Pedido(int numero, DateTime data, StatusPedido statusPedido)
        {
            Numero = numero;
            Data = data;
            StatusPedido = statusPedido;
        }

        public void AdicionarItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public double CalcularTotal()
        {
            double sum = 0.0;
            foreach(ItemPedido item in Itens)
            {
                sum += item.Subtotal();
            }

            return sum;
        }
    }
}
