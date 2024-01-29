using System;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-11-11T13:21:23");

            Console.WriteLine("Data original: " + d1);
            Console.WriteLine("Data loca: " + d1.ToLocalTime());
        }
    }
}
