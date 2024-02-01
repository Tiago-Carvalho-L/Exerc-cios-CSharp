using System;
using Projeto002.Entities;
using Projeto002.Extensions;

namespace ProjetoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DADOS PESSOAIS:");
            Console.WriteLine();
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Person person = new Person(firstName, lastName, age);

            string nomeCompleto = person.GetFullName();
            bool maiorIdade = person.IsAdult(18);

            Console.WriteLine();
            Console.WriteLine("Nome completo: " + nomeCompleto);
            if (maiorIdade == true)
            {
                Console.WriteLine("Essa pessoa é MAIOR DE IDADE.");
            }
            else
            {
                Console.WriteLine("Essa pessoa é MENOR DE IDADE.");
            }
        }
    }
}
