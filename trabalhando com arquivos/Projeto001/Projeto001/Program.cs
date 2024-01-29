using Projeto001.Entities;
using System;
using System.Globalization;
using System.IO;

namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();

            try
            {
                string sourcePath = Path.GetDirectoryName(path);
                string targetFolder = sourcePath + @"\out";
                string targetFile = targetFolder + @"\arquvioDestino.csv";

                Directory.CreateDirectory(targetFolder);

                using (StreamWriter sw = File.AppendText(targetFile))
                {
                    string[] lines = File.ReadAllLines(path);
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double preco = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(fields[2]);

                        Produto prod = new Produto(name, preco, quantidade);

                        sw.WriteLine(prod.Nome + ", " + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
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
