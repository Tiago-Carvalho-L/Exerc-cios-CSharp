using System;
using System.Collections.Generic;

namespace Projeto001
{
    class GenericsCollection<T>
    {
        public List<T> MyCollection { get; set; }

        public GenericsCollection()
        {
            MyCollection = new List<T>();
        }

        public void Add(T item)
        {
            MyCollection.Add(item);
        }

        public void Remove(T item)
        {
            if (MyCollection.Contains(item))
            {
                MyCollection.Remove(item);
            }
            else
            {
                throw new Exception("Item não encontrado na lista");
            }
        }

        public void ShowCollection()
        {
            foreach (T item in MyCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
