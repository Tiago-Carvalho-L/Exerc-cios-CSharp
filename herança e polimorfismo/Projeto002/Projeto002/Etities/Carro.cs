using System;
using System.Globalization;

namespace Projeto002.Etities
{
    class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public Carro()
        {

        }

        public Carro(string marca, int ano, double preco, int numeroPortas) : base(marca, ano, preco)
        {
            NumeroPortas = numeroPortas;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($", Número de portas: {NumeroPortas}");
        }
    }
}
