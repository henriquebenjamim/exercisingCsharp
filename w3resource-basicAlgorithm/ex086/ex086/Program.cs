using System;

namespace ex086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //86.Write a C# Sharp program to create a new string from a given string without the first and last character if the first or last characters are 'a' otherwise return the original given string.

            //Sample Input:
            //"abcab"
            //"python"
            //"abcda"
            //"jython"
            //Expected Output:
            //bcab
            //python
            //bcd
            //jython

            Console.WriteLine(firstOrLastA("abcab"));
            Console.WriteLine(firstOrLastA("python"));
            Console.WriteLine(firstOrLastA("abcda"));
            Console.WriteLine(firstOrLastA("jython"));
        }

        public static string firstOrLastA(string str)
        {
            return str.Length > 2 && str.Substring(0, 1) == "a" && str.Substring(str.Length - 1) == "a" ? str.Substring(1, str.Length - 2) :
                str.Substring(0, 1) == "a" ? str.Substring(1) :
                str.Substring(str.Length - 1) == "a" ? str.Substring(0, str.Length - 2) :
                str;
        }
    }
}
