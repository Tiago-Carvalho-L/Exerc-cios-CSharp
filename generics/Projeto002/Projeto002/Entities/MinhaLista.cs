using System.Collections.Generic;

namespace Projeto002.Entities
{
    class MinhaLista<T>
    {
        public List<T> Lista { get; set; }

        public MinhaLista()
        {

        }

        public MinhaLista(List<T> lista)
        {
            Lista = lista;
        }

        public void AdicionarItem (T item)
        {
            Lista.Add(item);
        }

        public void RemoverItem(T item)
        {
            Lista.Remove(item);
        }

        public int ContarItem()
        {
            return Lista.Count;
        }

        public void ObterTodosItens()
        {
            foreach(T item in Lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
