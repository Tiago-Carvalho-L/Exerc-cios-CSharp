using System;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor de 1 a 12: ");
            int numero = int.Parse(Console.ReadLine());
            string mes = Mes.MesDoAno(numero);

            Console.WriteLine();
            Console.WriteLine(mes);
        }
    }
}
