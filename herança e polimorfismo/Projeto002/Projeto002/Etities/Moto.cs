using System;
using System.Globalization;

namespace Projeto002.Etities
{
    class Moto: Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto()
        {

        }

        public Moto(string marca, int ano, double preco, int cilindradas) : base (marca, ano, preco)
        {
            Cilindradas = cilindradas;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($", Cilindradas: {Cilindradas}");
        }
    }
}
