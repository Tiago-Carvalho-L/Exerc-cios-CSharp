using Exercicio004;
using System;

namespace ExercicioQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para ser verificado: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"O número {numero} é: {VerificaNumero.Verificacao(numero)}");
        }
    }
}
