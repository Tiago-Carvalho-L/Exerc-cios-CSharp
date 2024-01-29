using System;

namespace ExercicioNove
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2023, 10, 1, 7, 30, 10, 10);//inicio
            DateTime d2 = new DateTime(2023, 10, 3, 19, 30, 10, 10);//fim
            DateTime d3 = d1.AddDays(5);
            DateTime d4 = new DateTime(2023, 10, 3, 16, 30, 10, 10);
            DateTime d5 = d1.AddMinutes(30);
            DateTime d6 = d1.AddMilliseconds(500);
            DateTime d7 = d2.AddMinutes(15);
            DateTime d8 = d1.AddMonths(2);
            //PRECISO SUBTRAIR 10 SEGUNDOS DO EVENTO MAS NAO SEI COMO FAZER
            DateTime d9 = d1.AddTicks(1000000000000);
            DateTime d10 = d1.AddYears(5);

            TimeSpan t1 = d2.Subtract(d1);// duracao do evento
            //TimeSpan t2 = d2.Subtract(d4);//subtraindo 3 horas [NAO ENTENDI COMO SUBTRAIR 3HORAS]

            Console.WriteLine("DIA DO EVENTO");
            Console.WriteLine();
            Console.WriteLine("Início do evento: " + d1);
            Console.WriteLine("Término do evento: " + d2);
            Console.WriteLine($"Duração do evento: {t1.Days} dia(s) e {t1.Hours} hora(s)");
            Console.WriteLine("Nova data (em caso de adiamento): "+ d3);
            //Console.WriteLine("Caso o término seja adiantado: " + t2); [NAO ENTENDI COMO SUBTRAIR 3HORAS]
            Console.WriteLine("Caso o início seja adiado: " + d5);
            Console.WriteLine("Caso o início seja adiado: " + d6);
            Console.WriteLine("Caso o término seja adiado: " + d7);
            Console.WriteLine("Caso seja necessária adiar por meses o evento: " + d8);
            //PRECISO SUBTRAIR 10 SEGUNDOS DO EVENTO MAS NAO SEI COMO FAZER
            Console.WriteLine("Adicionando ticks(nanosegundos) ao início do evento: " + d9);
            Console.WriteLine("Caso seja necessário adiar o evento por anos: " + d10);






        }
    }
}
