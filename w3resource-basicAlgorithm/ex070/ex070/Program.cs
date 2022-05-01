using System;

namespace ex070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //70.Write a C# Sharp program to create a new string without the first and last character of a given string of any length.

            //Sample Input:
            //"Hello"
            //"JS"
            //""
            //Expected Output:
            //ell

            Console.WriteLine(withoutFirstLast("Hello"));
            Console.WriteLine(withoutFirstLast("JS"));
            Console.WriteLine(withoutFirstLast(""));
        }

        public static string withoutFirstLast(string str)
        {
            return str.Length > 2 ? str.Substring(1, str.Length - 2) : "";
        }
    }
}
