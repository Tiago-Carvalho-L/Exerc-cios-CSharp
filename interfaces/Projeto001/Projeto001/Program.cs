using System;
using Projeto001.Entities;

namespace ProjetUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Celta");
            carro.Ligado(true);
            carro.Acelerar(60);

            Console.WriteLine();
            Moto moto = new Moto("Yamaha");
            moto.Ligado(false);
            moto.Acelerar(0);
        }
    }
}
