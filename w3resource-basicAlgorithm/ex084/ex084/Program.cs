using System;

namespace ex084
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //84.Write a C# Sharp program to create a new string from a given string.
            //If the two characters of the given string from its beginning and end are same return  the given string without the first two characters otherwise return the original string.

            //Sample Input:
            //"abcab"
            //"Python"
            //Expected Output:
            //cab
            //Python

            Console.WriteLine(firstTwoEqualsTwoEnd("abcab"));
            Console.WriteLine(firstTwoEqualsTwoEnd("Python"));
        }

        public static string firstTwoEqualsTwoEnd(string str)
        {
            return str.Length > 4 && str.Substring(0, 2) == str.Substring(str.Length - 2, 2) ? str.Substring(2): str;
        }
    }
}
