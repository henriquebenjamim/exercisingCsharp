using System;

namespace ex076
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //76.Write a C# Sharp program to create a new string of length 2, using first two characters of a given string.
            //If the given string length is less than 2 use '#' as missing characters.

            //Sample Input:
            //"Hello"
            //"Python"
            //"a"
            //""
            //Expected Output:
            //He
            //Py
            //a#
            //##

            Console.WriteLine(twoLen("Hello"));
            Console.WriteLine(twoLen("Python"));
            Console.WriteLine(twoLen("a"));
            Console.WriteLine(twoLen(""));
        }

        public static string twoLen(string str)
        {
            return str.Length > 2 ? str.Substring(0, 2) : str.Length == 1 ? str + "#" : "##";
        }
    }
}
