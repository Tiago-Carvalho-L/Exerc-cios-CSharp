using System;
using Projeto001.Entities.Interfaces;

namespace Projeto001.Entities
{
    class Moto : IVeiculo
    {
        public string Marca { get; set; }

        public Moto() { }

        public Moto(string marca)
        {
            Marca = marca;
        }

        public void Ligado(bool ligado)
        {
            if (ligado)
            {
                Console.WriteLine("A moto está ligada");
            }
            else
            {
                Console.WriteLine("A moto está desligada");
            }
        }

        public void Acelerar(int velocidade)
        {
            Console.WriteLine($"A moto está a {velocidade}km/h");
        }
    }
}
