using System;
using System.Globalization;
using Projeto001.Services;

namespace ProjetoUm
{
    class Program
    {
        delegate double OperacaoMatematica(double n1, double n2);
        static void Main(string[] args)
        {
            OperacaoMatematica op;

            try
            {
                Console.WriteLine("Digite dois números: ");
                Console.WriteLine();
                Console.Write("Primero número: ");
                double numero1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Segundo número: ");
                double numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Console.WriteLine("Qual operação você quer realizar? [1 - adição |2 - subtração |3 - multiplicação |4 - divisão]");
                int resposta = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (resposta)
                {
                    case 1:
                        op = Operacoes.Adicao;
                        Console.WriteLine("Resultado da adição: " + op(numero1, numero2).ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 2:
                        op = Operacoes.Subtracao;
                        Console.WriteLine("Resultado da subtração: " + op(numero1, numero2).ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 3:
                        op = Operacoes.Multiplicacao;
                        Console.WriteLine("Resultado da multiplicação: " + op(numero1, numero2).ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 4:
                        op = Operacoes.Divisao;
                        Console.WriteLine("Resultado da divisão: " + op(numero1, numero2).ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
