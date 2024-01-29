using System;
using System.Collections.Generic;
using Projeto001.Entities;


namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal1 = new Mammal("cadela", 11, 6);
            Mammal mammal2 = new Mammal("gata", 7, 6);
            Bird bird1 = new Bird("falcão", 12, 12.1);

            string mamiferoSom = mammal1.EmitirSom();
            string mamiferoAmamentar = mammal1.Amamentar();
            
            Console.WriteLine(mamiferoSom);
            Console.WriteLine(mamiferoAmamentar);
        }
    }
}
