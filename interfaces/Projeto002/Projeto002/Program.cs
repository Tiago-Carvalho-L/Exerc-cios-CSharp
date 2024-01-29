using System;
using System.IO;
using System.Collections.Generic;
using Projeto002.Entities;

namespace ProjetDois
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\pasta\produtos.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Product> list = new List<Product>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Product(sr.ReadLine()));
                    }
                    list.Sort();

                    foreach (Product p in list)
                    {
                        Console.WriteLine(p);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
