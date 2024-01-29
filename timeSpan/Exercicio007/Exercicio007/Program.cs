using Exercicio007;
using System;

namespace ExercicioSete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeito TimeSpan: ");
            string[] s = Console.ReadLine().Split(',');
            int hora = int.Parse(s[0]);
            int minuto = int.Parse(s[1]);
            int segundo = int.Parse(s[2]);
            TimeSpan t1 = new TimeSpan(hora, minuto, segundo);

            Console.WriteLine();
            Console.WriteLine("Digite o segundo TimeSpan: ");
            string[] s2 = Console.ReadLine().Split(',');
            int hora2 = int.Parse(s2[0]);
            int minuto2 = int.Parse(s2[1]);
            int segundo2 = int.Parse(s2[2]);
            TimeSpan t2 = new TimeSpan(hora2, minuto2, segundo2);

            OperacaoComTempo tempos = new OperacaoComTempo(t1, t2);

            Console.WriteLine();
            Console.WriteLine("[OPERAÇÕES]");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.Write("Escolha uma operação: ");
            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                Console.WriteLine($"A soma dos dois tempos é: {tempos.Sum()}");
            }
            else
            {
                Console.WriteLine($"A subtração dos tempos é: {tempos.Sub()}");
            }

        }
    }
}
