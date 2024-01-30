using System;
using System.Collections.Generic;

namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> palavras = new Dictionary<string, int>();

            Console.WriteLine("Escreva uma frase SEM VÍRGULAS: ");
            string[] frase = Console.ReadLine().Split(' ');
            Console.WriteLine();

            for(int i = 0; i < frase.Length; i++)
            {
                if (palavras.ContainsKey(frase[i]))
                {
                    palavras[frase[i]] += 1; 
                }
                else
                {
                    palavras[frase[i]] = 1;
                }
            }

            foreach(KeyValuePair<string, int> palavra in palavras)
            {
                Console.WriteLine($"{palavra.Key}: {palavra.Value}");
            }
        }
    }
}
