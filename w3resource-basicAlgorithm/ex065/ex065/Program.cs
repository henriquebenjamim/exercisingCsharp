using System;

namespace ex065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //65.Write a C# Sharp program to create a new string without the first and last character of a given string of length at least two. Go to the editor

            //Sample Input:
            //"Hello"
            //"Hi"
            //"Python"
            //Expected Output:
            //ell
            //
            //ytho

            Console.WriteLine(withoutFirstLast("Hello"));
            Console.WriteLine(withoutFirstLast("Hi"));
            Console.WriteLine(withoutFirstLast("Python"));
        }

        public static string withoutFirstLast(string str)
        {
            return str.Length >= 2 ? str.Substring(1, str.Length - 2) : str;
        }
    }
}
