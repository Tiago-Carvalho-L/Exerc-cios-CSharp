using Exercicio005;
using System;

namespace ExercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[NOVA PALAVRA]");
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            Console.Write("Digite um número: ");
            int indice = int.Parse(Console.ReadLine());
            Subpalavra palavra1 = new Subpalavra(palavra, indice);
            string palavra2 = palavra1.NovaPalavra();

            Console.WriteLine();
            Console.WriteLine("NOVA PALAVRA:");
            Console.WriteLine(palavra2);

        }
    }
}
