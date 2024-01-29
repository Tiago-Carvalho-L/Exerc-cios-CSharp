using Exercicio006;
using System;
using System.Globalization;

namespace ExercicioSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorConvertido = ConversorDeMoeda.ValorPago(cotacao, dolares);
            Console.Write("Valor a ser pago em reais = " + valorConvertido.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
