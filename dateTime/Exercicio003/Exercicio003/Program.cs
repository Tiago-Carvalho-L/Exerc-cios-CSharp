using System;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2023, 12, 1);
            DateTime d2 = DateTime.Now;

            TimeSpan d3 = d1.Subtract(d2);

            Console.WriteLine($"faltam {d3.Days} dias, {d3.Hours} horas, {d3.Minutes} minutos e {d3.Seconds} segundos");

        }
    }
}
