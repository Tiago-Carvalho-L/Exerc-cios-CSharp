using System;
using System.Globalization;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-11-23T13:30:20");

            Console.WriteLine("Data e hora original: " + d1);
            Console.WriteLine("Data e hora utc: " + d1.ToUniversalTime());
        }
    }
}
