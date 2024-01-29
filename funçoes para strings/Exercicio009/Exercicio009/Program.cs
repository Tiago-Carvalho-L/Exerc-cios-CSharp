using Exercicio009;
using System;

namespace ExercicioNove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            VerificaCampo verifica = new VerificaCampo(nome);

            Console.WriteLine(verifica.Resposta());
        }
    }
}
