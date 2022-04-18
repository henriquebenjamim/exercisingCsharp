using System;

namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Write a C# Sharp program to exchange the first and last characters in a given string and return the new string. Go to the editor

            //Sample Input:
            //"abcd"
            //"a"
            //"xy"
            //Expected Output:

            //dbca
            //a
            //yx

            Console.WriteLine(reversingCharacters("abcd"));
            Console.WriteLine(reversingCharacters("a"));
            Console.WriteLine("xy");
        }

        public static string reversingCharacters(string str)
        {
            return str.Length > 1 ? str : str.Substring(1, str.Length - 1) + str.Substring(0, 1);
        }
    }
}
