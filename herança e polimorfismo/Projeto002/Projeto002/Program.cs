using Projeto002.Etities;
using System;
using System.Globalization;

namespace ProjetoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro = new Carro("Toyota", 2010, 23000.0, 4);
            Veiculo moto = new Moto("Yamaha", 2013, 15000.0, 50);

            carro.ExibirDetalhes();
            moto.ExibirDetalhes();
        }
    }
}
