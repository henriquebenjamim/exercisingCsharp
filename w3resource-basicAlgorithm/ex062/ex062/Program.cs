using System;

namespace ex062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //62.Write a C# Sharp program to create a new string using three copies of the last two character of a given string of length atleast two. Go to the editor

            //Sample Input:
            //"Hello"
            //"Hi"
            //Expected Output:
            //lololo
            //HiHiHi

            Console.WriteLine(threeCopies("Hello"));
            Console.WriteLine(threeCopies("Hi"));
        }

        public static string threeCopies(string str)
        {
            return str.Length > 2 ? $"{str.Substring(str.Length - 2)}{str.Substring(str.Length - 2)}{str.Substring(str.Length - 2)}" : $"{str}{str}{str}";
        }
    }
}
