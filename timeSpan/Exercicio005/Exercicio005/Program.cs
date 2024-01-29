using System;

namespace ExercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 20, 30);
            TimeSpan t2 = new TimeSpan(1, 10, 20);

            if (t1 > t2)
            {
                Console.WriteLine($"O maior é o {t1} e o menor é o {t2}");
            }
            else
            {
                Console.WriteLine($"O maior é o {t2} e o menor é o {t1}");
            }
        }
    }
}
