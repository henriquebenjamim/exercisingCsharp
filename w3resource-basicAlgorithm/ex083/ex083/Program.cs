using System;
using System.Linq;

namespace ex083
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //83.Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string.
            //If the length of the given string is less than 2 use the whole string.

            //Sample Input:
            //"abc"
            //"Python"
            //"J"
            //Expected Output:
            //ababab
            //PyPyPy
            //JJJ

            Console.WriteLine(threeCopies("abc"));
            Console.WriteLine(threeCopies("Python"));
            Console.WriteLine(threeCopies("J"));
        }

        public static string threeCopies(string str)
        {

            return str.Length > 2 ? string.Concat(Enumerable.Repeat(str.Substring(0, 2), 3)) : string.Concat(Enumerable.Repeat(str, 3));
        }
    }
}
