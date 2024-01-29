using Exercicio004;
using System;

namespace ExercicioQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Faixa etária: " + ClassificacaoIdade.Classificao(idade));
        }
    }
}
