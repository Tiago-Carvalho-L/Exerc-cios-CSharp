using Exercicio002;
using System;
using System.Globalization;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 nota: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("2 nota: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            MediaFinal notas = new MediaFinal(nota1, nota2);

            Console.WriteLine();
            Console.WriteLine("Média final: " + notas.Media().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(notas.AprovadoOuReprovado());
            
        }
    }
}
