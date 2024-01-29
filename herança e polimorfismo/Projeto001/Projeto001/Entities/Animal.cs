using System;

namespace Projeto001.Entities
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal()
        {

        }

        public Animal (string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string EmitirSom()
        {
            return "O animal emitiu um som!";
        }
    }
}
