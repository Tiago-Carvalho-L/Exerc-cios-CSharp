using System;

namespace Exercicio003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase com espaços antes e depois: ");
            string resposta = Console.ReadLine();
            RemoveEspacos frase = new RemoveEspacos(resposta);

            Console.WriteLine(frase.EspacosBrancos());
        }
    }
}
