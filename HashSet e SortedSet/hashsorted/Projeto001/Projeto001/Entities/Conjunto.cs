using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace Projeto001.Entities
{
    class Conjunto
    {
        public SortedSet<int> Collection {  get; set; } = new SortedSet<int>();

        public void AdicionarElementos(int quantidade, string[] vet)
        {
            int quantidadeElementos = quantidade;
            string[] vetor = vet;
            for (int i = 0; i < quantidadeElementos; i++)
            {
                int elemento = int.Parse(vetor[i]);
                Collection.Add(elemento);
            }
        }

        public void MostrarColecao()
        {
            foreach (int elemento in Collection)
            {
                Console.Write(elemento + " ");
            }
        }
    }
}
