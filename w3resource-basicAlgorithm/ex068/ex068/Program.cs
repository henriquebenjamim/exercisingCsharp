using System;

namespace ex068
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //68.Write a C# Sharp program to move the first two characters to the end of a given string of length at least two.

            //Sample Input:
            //"Hello"
            //"JS"
            //Expected Output:
            //lloHe
            //JS

            Console.WriteLine(firstTwoToEnd("Hello"));
            Console.WriteLine(firstTwoToEnd("JS"));
        }

        public static string firstTwoToEnd(string str)
        {
            return str.Length > 2 ? str.Substring(2) + str.Substring(0, 2) : str;
        }
    }
}
