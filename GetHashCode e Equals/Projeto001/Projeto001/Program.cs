using System;
using System.Collections;
using Projeto001.Entities;

namespace ProjetUm
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> set = new HashSet<Person>();

            set.Add(new Person("Maria", "Brown"));
            set.Add(new Person("Alex", "Green"));

            Person person = new Person("Maria", "Brown");

            Console.WriteLine(set.Contains(person));
        }
    }
}
