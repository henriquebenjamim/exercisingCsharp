using System;

namespace ex082
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //82.Write a C# Sharp program to combine two given strings.
            //If the given strings have different length remove the characters from the longer string.

            //Sample Input:
            //"abc", "abcd"
            //"Python", "Python"
            //"JS", "Python"
            //Expected Output:
            //abcbcd
            //PythonPython
            //JSon

            Console.WriteLine(combineStr("abc", "abcd"));
            Console.WriteLine(combineStr("Python", "Python"));
            Console.WriteLine(combineStr("JS", "Python"));
            
        }

        public static string combineStr(string str1, string str2)
        {
            return str1.Length < str2.Length ? $"{str1}{str2.Substring(str2.Length - str1.Length, str1.Length)}" : 
                str1.Length > str2.Length ? $"{str1}{str2.Substring(str2.Length - str1.Length, str1.Length)}" :
                str1.Length == str2.Length ? str1 + str2: "";
        }
    }
}
