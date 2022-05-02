using System;

namespace ex074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //74.Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.

            //Sample Input:
            //"Hello", 1
            //"Python", 2
            //"on", 1
            //Expected Output:
            //el
            //th
            //on

            Console.WriteLine(newTwoLen("Hello", 1));
            Console.WriteLine(newTwoLen("Python", 2));
            Console.WriteLine(newTwoLen("on", 1));
        }

        public static string newTwoLen(string str, int indNumber)
        {
            int nextIndNumber = indNumber + 1;
            return str.Length > 2 ? str.Substring(indNumber, 2) : str;
        }
    }
}
