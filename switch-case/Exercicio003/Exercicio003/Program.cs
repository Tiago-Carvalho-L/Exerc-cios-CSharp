using Exercicio003;
using System;
using System.Globalization;
namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira dois números e um operador(+, -, *, /): ");
            string[] vect = Console.ReadLine().Split(' ');
            double numero1 = double.Parse(vect[0]);
            double numero2 = double.Parse(vect[1]);
            string operador = vect[2];

            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                Console.WriteLine("Operador inválido");
            }
            else
            {
                Calculadora operacao = new Calculadora(numero1, numero2, operador);

                double conta = operacao.Operacao();

                Console.WriteLine("Resultado da operação: " + conta.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
