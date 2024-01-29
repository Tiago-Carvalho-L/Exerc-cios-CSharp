using System;
using System.Collections.Generic;
using Projeto002.Services;

namespace ProjetoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABALHANDO COM CONJUNTOS:");
            Console.WriteLine();

            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            try
            {
                Console.WriteLine("Vamos criar duas listas");
                Console.Write("Digite o número de elementos que as listas vão ter: ");
                int numberElementsList = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite os elementos da primeira lista:");
                for (int i = 1; i <= numberElementsList; i++)
                {
                    Console.Write($"{i}° elemento: ");
                    int element = int.Parse(Console.ReadLine());
                    firstList.Add(element);
                }
                HashSet<int> firstSet = new HashSet<int>(firstList);
                Console.WriteLine();

                Console.WriteLine("Digite os elementos da segunda lista:");
                for (int i = 1; i <= numberElementsList; i++)
                {
                    Console.Write($"{i}° elemento: ");
                    int element = int.Parse(Console.ReadLine());
                    secondList.Add(element);
                }
                HashSet<int> secondSet = new HashSet<int>(secondList);
                
                Conjunto.PrintCollection(firstSet, secondSet);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

    }
}
