using System;

namespace ex069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //69.Write a C# Sharp program to move the last two characters to the start of a given string of length at least two.

            //Sample Input:
            //"Hello"
            //"JS"
            //Expected Output:
            //loHel
            //JS

            Console.WriteLine(lastTwoToStart("Hello"));
            Console.WriteLine(lastTwoToStart("Hi"));
            Console.WriteLine(lastTwoToStart("JS"));

        }

        public static string lastTwoToStart(string str)
        {
            return str.Length >= 2 ? $"{str.Substring(str.Length - 2)}{str.Substring(0, str.Length - 2)}" : str;
        }
    }
}
