using System;
using Projeto003.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoTres
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Console.Write("Quantidade de pessoas que serão adicionadas na lista: ");
            int quantidadePessoas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("INFORMAÇÕES:");
            Console.WriteLine();

            try
            {
                for (int i = 0; i < quantidadePessoas; i++)
                {
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Data de nascimento: ");
                    DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    pessoas.Add(new Pessoa(id, nome, dataNascimento));
                    Console.WriteLine();
                }

                Console.WriteLine("Códigos Hash de cada pessoa:");
                foreach (Pessoa p in pessoas)
                {
                    Console.WriteLine(p.GetHashCode());
                }

                Console.WriteLine();
                Console.WriteLine($"O {pessoas[0].Nome} é igual ao(a):");
                for (int i = 1; i < pessoas.Count; i++)
                {
                    if (pessoas[0].Equals(i))
                    {
                        Console.WriteLine($"{pessoas[i].Nome}: é igual");
                    }
                    else
                    {
                        Console.WriteLine($"{pessoas[i].Nome}: não é igual");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

