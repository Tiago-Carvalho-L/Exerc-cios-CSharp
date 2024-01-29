using System;

namespace ExercicioQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 30, 50);
            TimeSpan t2 = new TimeSpan(0, 20, 10);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);

            Console.WriteLine("[OPERAÇÕES COM TIMESPAN]");
            Console.WriteLine("1° TimeSpan: " + t1);
            Console.WriteLine("2° TimeSpan: " + t2);
            Console.WriteLine("Soma: " +  sum);
            Console.WriteLine("Diferença: " + dif);
            Console.WriteLine("Multiplicando o segundo TimeSpan por 2.0: " + mult);
            Console.WriteLine("Dividindo o segundo TimeSpan por 2.0: " + div);
        }
    }
}
