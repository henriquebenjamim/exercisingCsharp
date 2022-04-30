using System;

namespace ex063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //63.Write a C# Sharp program to create a new string using first two characters of a given string. If the string length is less than 2 then return the original string..

            //Sample Input:
            //"Hello"
            //"Hi"
            //"H"
            //" "
            //Expected Output:
            //He
            //Hi
            //H

            Console.WriteLine(firstTwo("Hello"));
            Console.WriteLine(firstTwo("Hi"));
            Console.WriteLine(firstTwo("H"));
            Console.WriteLine(firstTwo(" "));
        }

        public static string firstTwo(string str)
        {
            return str.Length >= 2 ? str.Substring(0, 2) : str;
        }
    }
}
