using Exercicio004;
using System;

namespace ExercicioQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string resposta1 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite uma palavra contida na frase: ");
            string resposta2 = Console.ReadLine();

            EncontraPalavras grupo1 = new EncontraPalavras(resposta1, resposta2);

            Console.WriteLine();
            Console.WriteLine($"A primeira ocorrência da palavra '{resposta2}' é: {grupo1.IndicePalavra()}");
        }
    }
}
