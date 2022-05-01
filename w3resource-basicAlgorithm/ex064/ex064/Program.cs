using System;

namespace ex064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //64.Write a C# Sharp program to create a new string of the first half of a given string of even length. Go to the editor

            //Sample Input:
            //"Hello"
            //"Hi"
            //Expected Output:
            //He
            //H

            Console.WriteLine(firstHalf("Hello"));
            Console.WriteLine(firstHalf("Hi"));
        }

        public static string firstHalf(string str)
        {
            return str.Length >= 2 ? str.Substring(0, str.Length / 2) : str;
        }
    }
}
