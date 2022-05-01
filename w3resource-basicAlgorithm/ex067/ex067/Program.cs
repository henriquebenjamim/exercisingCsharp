using System;

namespace ex067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //67.Write a C# Sharp program to concat two given string of length atleast 1, after removing their first character.

            //Sample Input:
            //"Hello", "Hi"
            //"JS", "Python"
            //Expected Output:
            //elloi
            //Sython

            Console.WriteLine(concatWithoutFirst("Hello", "Hi"));
            Console.WriteLine(concatWithoutFirst("JS", "Python"));
        }

        public static string concatWithoutFirst(string firstStr, string secondStr)
        {
            return firstStr.Length > 2 ? $"{firstStr.Substring(1)}{secondStr.Substring(1)}" : $"{firstStr.Substring(1)}{secondStr.Substring(1)}";
        }
    }
}
