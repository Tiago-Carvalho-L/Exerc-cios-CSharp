using System;

namespace ExercicioSeis
{
    class Program
    {
         static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 20, 40);

            Console.WriteLine("TimeSpan: " + t1);
            Console.WriteLine("Horas: " + t1.Hours);
            Console.WriteLine("Minutos: " + t1.Minutes);
            Console.WriteLine("Segundos: " + t1.Seconds);
        }
    }
}
