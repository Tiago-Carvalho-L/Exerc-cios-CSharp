using Exercicio007;
using System;

namespace ExercicioSete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            TrocaLetras novaFrase = new TrocaLetras(frase);

            Console.WriteLine();
            Console.WriteLine("FRASE ALTERADA: ");
            Console.WriteLine(novaFrase.AlteraLetra());
        }
    }
}
