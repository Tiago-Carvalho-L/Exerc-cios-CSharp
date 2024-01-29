using System;

namespace ExercicioSete
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 01, 23, 13, 23, 21, 12);

            Console.WriteLine("DATA DE NASCIMENTO");
            Console.WriteLine();
            Console.WriteLine("Data: " + d1.Date);
            Console.WriteLine("Dia da semana: " + d1.DayOfWeek);
            Console.WriteLine("Dia do ano: " + d1.DayOfYear);
            Console.WriteLine("Horário: " + d1.Hour);
            Console.WriteLine("Kind: " + d1.Kind);
            Console.WriteLine("Millisegundos: " + d1.Millisecond);
            Console.WriteLine("Minutos: " + d1.Minute);
            Console.WriteLine("Mês: " + d1.Month);
            Console.WriteLine("Segundos: " + d1.Second);
            Console.WriteLine("Ticks: " + d1.Ticks);
            Console.WriteLine("Hora do dia: " + d1.TimeOfDay);
            Console.WriteLine("Ano: " + d1.Year);
        }
    }
}
