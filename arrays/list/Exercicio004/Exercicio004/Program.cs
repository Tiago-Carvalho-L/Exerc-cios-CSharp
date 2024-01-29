using System;
using System.Collections.Generic;

namespace ExercicioQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"Maria", "João", "Alan", "Adan", "Aline"};

            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine();
            Console.WriteLine($"Primeiro nome da lista que começa com 'A': {list.FindIndex(x => x[0] == 'A' || x[0] == 'a')}");
            Console.WriteLine($"Útimo nome da lista que começa com 'A': {list.FindLastIndex(x => x[0] == 'A' || x[0] == 'a')}");
        }
    }
}
