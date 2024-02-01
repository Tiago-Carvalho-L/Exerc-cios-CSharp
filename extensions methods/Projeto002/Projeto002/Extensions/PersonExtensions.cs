using System;
using Projeto002.Entities;

namespace Projeto002.Extensions
{
    static class PersonExtensions
    {
        public static string GetFullName(this Person person)
        {
            return person.FirstName + " " + person.LastName;
        }

        public static bool IsAdult(this Person person, int minimumAge)
        {
            if (person.Age >= minimumAge)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
