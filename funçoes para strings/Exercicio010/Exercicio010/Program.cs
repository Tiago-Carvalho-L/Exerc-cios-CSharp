using Exercicio010;
using System;

namespace ExercicioDez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            ValidadorDeCampo campoNome = new ValidadorDeCampo(nome);

            Console.WriteLine(campoNome.Retorna());
        }
    }
}
