using System;

namespace Exercicio001.Entities
{
    class PedidoItem
    {
        public Produto Produto { get; set; }
        public int Quantida { get; set; }

        public PedidoItem()
        {

        }

        public PedidoItem(Produto produto, int quantida)
        {
            Produto = produto;
            Quantida = quantida;
        }
    }
}
