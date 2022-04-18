using System;

namespace ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //17.Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string.

            //Sample Input:
            //"Python"
            //"ytade"
            //"jsues"
            //Expected Output:
            //Phon
            //ytade
            //jsues


            Console.WriteLine(removingSomeCharacters("Python"));
            Console.WriteLine(removingSomeCharacters("ytade"));
            Console.WriteLine(removingSomeCharacters("jsues"));
        }

        public static string removingSomeCharacters(string str)
        {
            return str.Length > 1 && str.Substring(1, 2) == "yt" ? str.Substring(0, 1) + str.Substring(3): str;
        }
    }
}
