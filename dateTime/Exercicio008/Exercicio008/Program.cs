using System;

namespace ExercicioOito
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2020, 11, 12, 13, 45, 33, 01);

            Console.WriteLine("DATA DE UM EVENTO IMPORTANTE");
            Console.WriteLine();
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToShortTimeString());
            Console.WriteLine(d1.ToString());
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }
    }
}
