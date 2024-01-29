using System;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(01, 03, 23);
            TimeSpan t4 = new TimeSpan(02, 02, 01, 23);
            TimeSpan t5 = new TimeSpan(02, 03, 04, 43, 59);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
        }
    }
}
