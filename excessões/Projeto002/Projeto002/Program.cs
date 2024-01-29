using System;
using System.Globalization;

namespace ProjetoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("ESCREVA DOIS NÚMEROS INTEIROS: ");
                string[] s = Console.ReadLine().Split(' ');
                int primeiroNumero = int.Parse(s[0]);
                int segundoNumero = int.Parse(s[1]);

                double resultado = (double)primeiroNumero / segundoNumero;
                Console.WriteLine($"O resultado da divisão de {primeiroNumero} por {segundoNumero} é: "
                    + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro: entrada inválida");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
