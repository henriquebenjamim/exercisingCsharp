using System;

namespace ex081
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //81.Write a C# Sharp program to check whether the first two characters and last two characters of a given string are same.

            //Sample Input:
            //"abab"
            //"abcdef"
            //"xyzsderxy"
            //Expected Output:
            //True
            //False
            //True

            Console.WriteLine(firstLastTwoEquals("abab"));
            Console.WriteLine(firstLastTwoEquals("abcdef"));
            Console.WriteLine(firstLastTwoEquals("xyzsderxy"));
        }

        public static bool firstLastTwoEquals(string str)
        {
            return str.Length >= 4 ? str.Substring(0, 2) == str.Substring(str.Length -2, 2) : false;
        }
    }
}
