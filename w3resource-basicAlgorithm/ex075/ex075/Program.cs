using System;

namespace ex075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //75.Write a C# Sharp program to create a new string taking 3 characters from the middle of a given string at least 3.

            //Sample Input:
            //"Hello"
            //"Python"
            //"abc"
            //Expected Output:
            //ell
            //yth
            //abc

            Console.WriteLine(threeStr("Hello"));
            Console.WriteLine(threeStr("Python"));
            Console.WriteLine(threeStr("abc"));
        }

        public static string threeStr(string str)
        {
            int middleStr = str.Length / 2;
            return str.Length > 3 ? middleStr % 2 == 0 ? str.Substring(middleStr -1, middleStr + 1) : str.Substring(middleStr - 2, middleStr ) : str;
        }
    }
}
