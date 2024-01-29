using System;
using System.Globalization;

namespace ExercicioSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            string d1 = "2000-11-23 13:13:14";

            DateTime d2 = DateTime.ParseExact(d1, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
