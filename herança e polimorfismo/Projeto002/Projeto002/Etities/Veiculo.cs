using System;
using System.Globalization;

namespace Projeto002.Etities
{
    class Veiculo
    {
        public string Marca { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string marca, int ano, double preco)
        {
            Marca = marca;
            Ano = ano;
            Preco = preco;
        }

        public virtual void ExibirDetalhes()
        {
            Console.Write($"Marca: {Marca}, Ano: {Ano}, Preço: {Preco.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
