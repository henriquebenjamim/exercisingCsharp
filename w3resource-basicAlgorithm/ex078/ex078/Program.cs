using System;

namespace ex078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //78.Write a C# Sharp program to combine two given strings (lowercase). If there are any double character in new string then omit one character.

            //Sample Input:
            //"abc", "cat"
            //"python", "php"
            //"php", "php"
            //Expected Output:
            //abcat
            //pythonphp
            //phphp

            Console.WriteLine(concatLowerStr("abc", "cat"));
            Console.WriteLine(concatLowerStr("python", "php"));
            Console.WriteLine(concatLowerStr("php", "php"));
        }

        public static string concatLowerStr(string str1, string str2)
        {
            return str1.Substring(str1.Length - 1) == str2.Substring(0, 1) ? str1 + str2.Substring(1, str2.Length - 1) : str1 + str2;
        }
    }
}
