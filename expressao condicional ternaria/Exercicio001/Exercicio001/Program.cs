using Exercicio001;
using System;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[PAR OU ÍMPAR]");

            int resposta = 1;

            while (resposta == 1)
            {
                Console.WriteLine();
                Console.Write("Digite um número para ser avaliado: ");
                int numero = int.Parse(Console.ReadLine());
                string parOuImpar = ParOuImpar.AnalisaNumero(numero);

                Console.WriteLine($"O número {numero} é {parOuImpar}");
                
                Console.WriteLine();
                Console.WriteLine("Quer avaliar outro número? 1-[SIM] | 2-[NÃO]");
                resposta = int.Parse(Console.ReadLine());
            }
        }
    }
}
