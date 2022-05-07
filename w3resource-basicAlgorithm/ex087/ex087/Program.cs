using System;

namespace ex087
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //87.Write a C# Sharp program to create a new string from a given string.
            //If the first or first two characters is 'a', return the string without those 'a' characters otherwise return the original given string.

            //Sample Input:
            //"abcab"
            //"python"
            //"aacda"
            //"jython"

            //Expected Output:
            //bcab
            //python
            //cda
            //jython

            Console.WriteLine(firstTwoA("abcab"));
            Console.WriteLine(firstTwoA("python"));
            Console.WriteLine(firstTwoA("aacda"));
            Console.WriteLine(firstTwoA("jython"));
        }

        public static string firstTwoA(string str)
        {
            return str.Length > 2 && str.Substring(0, 2) == "aa" ? str.Substring(2) :
                str.Substring(0, 1) == "a" ? str.Substring(1) : str;
        }
    }
}
