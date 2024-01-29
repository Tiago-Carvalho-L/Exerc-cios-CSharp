using Exercicio002;
using System;
using System.Globalization;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do primeiro funcinário: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario funcionario1 = new Funcionario(nome, salario);

            Console.WriteLine("Dados do segundo funcinário: ");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Salário: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario funcionario2 = new Funcionario(nome, salario);

            double salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine();
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
