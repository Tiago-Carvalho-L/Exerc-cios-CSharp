using System;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 1 a 7: ");
            int number = int.Parse(Console.ReadLine());
            string dayOfWeek = Days.DiaSemana(number);

            Console.WriteLine(dayOfWeek);
        }
    }
}