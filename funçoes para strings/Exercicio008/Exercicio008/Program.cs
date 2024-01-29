using Exercicio008;
using System;

namespace ExercicioOito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase que sera alterada: ");
            string frase = Console.ReadLine();
            AlteraFrase mudaFrase = new AlteraFrase(frase);

            Console.WriteLine();
            Console.WriteLine("FRASE ALTERADA: ");
            Console.WriteLine(mudaFrase.NovaFrase());
        }
    }
}
