using System;
using System.Collections.Generic;

namespace ProjetoTres
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                int student = int.Parse(Console.ReadLine());
                courseA.Add(student);
            }

            Console.Write("How many students for course B? ");
            numberOfStudents = int.Parse(Console.ReadLine());

            for ( int i = 0; i < numberOfStudents; i++)
            {
                int student = int.Parse(Console.ReadLine());
                courseB.Add(student);
            }

            Console.Write("How many students for course C? ");
            numberOfStudents = int.Parse(Console.ReadLine());

            for ( int i = 0; i < numberOfStudents; i++)
            {
                int student = int.Parse(Console.ReadLine());
                courseC.Add(student);
            }

            HashSet<int> totalStudents = new HashSet<int>(courseA);
            totalStudents.UnionWith(courseB);
            totalStudents.UnionWith(courseC);

            Console.WriteLine("Total students: " + totalStudents.Count);

        }
    }
}
