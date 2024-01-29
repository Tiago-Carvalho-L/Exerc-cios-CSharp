using Exercicio002;
using System;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase: ");
            string resposta = Console.ReadLine();
            ContagemDeLetras texto = new ContagemDeLetras(resposta);

            Console.WriteLine(texto.ContagemDeA());

        }
    }
}
