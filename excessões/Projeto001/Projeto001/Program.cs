using System;
using System.IO;

namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o caminho do arquivo: ");
                string sourcePath = Console.ReadLine();
                string targetPath = @"c:\pasta\file3.txt";
                FileInfo fs = new FileInfo(sourcePath);
                fs.CopyTo(targetPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
