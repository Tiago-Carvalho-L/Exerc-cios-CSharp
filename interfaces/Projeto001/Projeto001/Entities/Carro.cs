using System;
using Projeto001.Entities.Interfaces;

namespace Projeto001.Entities
{
    class Carro: IVeiculo
    {
        public string Modelo { get; set; }

        public Carro() { }

        public Carro(string modelo)
        {
            Modelo = modelo;
        }

        public void Ligado(bool ligado)
        {
            if (ligado)
            {
                Console.WriteLine("O carro está ligado");
            }
            else
            {
                Console.WriteLine("O carro está desligado");
            }
        }

        public void Acelerar(int velocidade)
        {
            Console.WriteLine($"O carro está a {velocidade}km/h");
        }
    }
}
