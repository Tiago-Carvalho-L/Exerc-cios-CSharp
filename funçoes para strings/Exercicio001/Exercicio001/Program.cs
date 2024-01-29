using Exercicio001;
using System;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase com letras maiúsculas: ");
            string resposta = Console.ReadLine();
            Lower frase = new Lower(resposta);

            Console.WriteLine(frase.FraseMinuscula());
        }
    }
}
