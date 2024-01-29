using System;

namespace ExercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data no formato dd/MM/yyyy:");
            DateTime d1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(d1);
        }
    }
}
