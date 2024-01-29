using System;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UMA DATA");
            Console.WriteLine();
            Console.Write("Dia(s): ");
            int dias = int.Parse(Console.ReadLine());
            Console.Write("Hora(s): ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Minuto(s): ");
            int minutos = int.Parse(Console.ReadLine());
            Console.Write("Segundo(s): ");
            int segundos = int.Parse(Console.ReadLine());
            Console.Write("Milissegundo(s): ");
            int milissegundos = int.Parse(Console.ReadLine());

            TimeSpan t1 = new TimeSpan(dias, horas, minutos, segundos, milissegundos);

            Console.WriteLine();
            Console.WriteLine("[DATA]");
            Console.WriteLine();
            Console.WriteLine($"Dia(s): {t1.Days}");
            Console.WriteLine($"Hora(s): {t1.Hours}");
            Console.WriteLine($"Minuto(s): {t1.Minutes}");
            Console.WriteLine($"Segundo(s): {t1.Seconds}");
            Console.WriteLine($"Milisegundo(s): {t1.Milliseconds}");
            Console.WriteLine($"Tick(s): {t1.Ticks}");
            Console.WriteLine($"TotalDays: {t1.TotalDays}");
            Console.WriteLine($"TotalHours: {t1.TotalHours}");
            Console.WriteLine($"TotalMinutes: {t1.TotalMinutes}");
            Console.WriteLine($"TotalSeconds: {t1.TotalSeconds}");
            Console.WriteLine($"TotalMilliseconds: {t1.TotalMilliseconds}");
        }
    }
}
