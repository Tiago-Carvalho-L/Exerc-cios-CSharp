using Exercicio005;
using System;
using System.Globalization;

namespace ExercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno aluno1 = new Aluno(nome ,nota1, nota2, nota3);

            Console.WriteLine("NOTA FINAL = " + aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno1.NotaFinal() > 60.0)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno1.PontosRestantes().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
