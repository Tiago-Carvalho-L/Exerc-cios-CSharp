using Exercicio003;
using System;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            MaiorIdade pessoa1 = new MaiorIdade(idade);
            Console.WriteLine($"Este usuário é: {pessoa1.ClassificacaoEtaria()}");
        }
    }
}
