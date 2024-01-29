using System;

namespace Exercicio001
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensionato[] quartos = new Pensionato[10];

            Console.Write("Quantos quarto serão alugados? ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                quartos[quarto] = new Pensionato(nome, email, quarto);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i]);
                }
            }
        }
    }
}
