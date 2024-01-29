using Exercicio005;
using System;

namespace ExercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite tres números inteiros: ");
            string[] s = Console.ReadLine().Split(' ');
            int numero1 = int.Parse(s[0]);
            int numero2 = int.Parse(s[1]);
            int numero3 = int.Parse(s[2]);

            MaiorNumero numeros = new MaiorNumero(numero1, numero2, numero3);

            int maiorNumero = numeros.VerificaNumero();

            Console.WriteLine("o maior número é o: " + maiorNumero);
        }
    }
}
