using Exercicio006;
using System;

namespace ExercicioSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[GERADOR DE NOVAS PALAVRAS]");
            Console.WriteLine();
            Console.Write("Digite uma palavra: ");
            string palalvra = Console.ReadLine();
            Console.Write("Digite um indice para iniciar a palavra: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("Digite um indice para terminar a palavra: ");
            int tamanho = int.Parse(Console.ReadLine());
            SubPalavra novaPalavra = new SubPalavra(palalvra, inicio, tamanho);

            Console.WriteLine();
            Console.WriteLine("NOVA PALAVRA GERADA: ");
            Console.WriteLine(novaPalavra.NovaPalavra());
        }
    }
}
