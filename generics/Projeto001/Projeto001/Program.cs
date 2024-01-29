using Projeto001;
using System;
using System.Collections.Generic;

namespace ProjetUm
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericsCollection<string> genericsCollection = new GenericsCollection<string>();

            try
            {
                Console.Write("Quantos elementos serão adicionados na lista? ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string s = Console.ReadLine();
                    genericsCollection.Add(s);
                }

                Console.WriteLine();
                Console.WriteLine("ELEMENTOS ADICINADOS NA LISTA");
                genericsCollection.ShowCollection();

                Console.WriteLine();
                Console.Write("Gostaria de remover algum elemento da lista? [S/N]");
                string resp = Console.ReadLine().ToLower();
                char res = char.Parse(resp);
                

                if (res == 's')
                {
                    Console.Write("Qual elemento deverá ser removido? ");
                    int ele = int.Parse(Console.ReadLine());
                    genericsCollection.Remove(genericsCollection.MyCollection[ele]);
                }

                Console.WriteLine();
                Console.WriteLine("LISTA ATUALIZADA");
                genericsCollection.ShowCollection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
