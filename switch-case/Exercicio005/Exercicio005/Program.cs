using Exercicio005;
using System;
using System.Globalization;

namespace ExercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um tipo de conversão:");
            Console.WriteLine();
            Console.WriteLine("1 - Centímetros em Metros");
            Console.WriteLine("2 - Gramas em Quilos");
            Console.WriteLine("3 - Mililitros em Litros");
            Console.WriteLine();
            Console.Write("Tipo: ");
            int tipo = int.Parse(Console.ReadLine());

            if (tipo != 1 && tipo != 2 && tipo != 3)
            {
                Console.WriteLine("Tipo inválido");
            }
            else
            {
                Console.Write("Digite o valor: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ConversorDeUnidades conversao = new ConversorDeUnidades(tipo, valor);
                double resultadoConversao = conversao.TipoDeConversao();

                Console.WriteLine("Resultado da conversão: " + resultadoConversao.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
