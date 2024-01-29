using Projeto002.Entities;

namespace Projeto002.Entities
{
    class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public ItemPedido()
        {

        }

        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public double Subtotal()
        {
            return Produto.Preco * Quantidade;
        }
    }
}
