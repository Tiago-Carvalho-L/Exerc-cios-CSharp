using System;
using System.Collections.Generic;

namespace Projeto001.Extensions
{
    static class ListExtensions
    {
        public static List<int> FiltrarPares(this List<int> list)
        {
            List<int> ints = new List<int>();

            foreach (int item in list)
            {
                if (item % 2 == 0)
                {
                    ints.Add(item);
                }
            }

            return ints;
        }
    }
}
