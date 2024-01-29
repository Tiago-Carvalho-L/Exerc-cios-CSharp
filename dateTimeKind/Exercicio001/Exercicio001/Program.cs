using System;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 11, 01, 13, 20, 30, DateTimeKind.Local);

            Console.WriteLine(d1);
            Console.WriteLine("Kind: " + d1.Kind);
            Console.WriteLine(d1.ToUniversalTime());
        }
    }
}
