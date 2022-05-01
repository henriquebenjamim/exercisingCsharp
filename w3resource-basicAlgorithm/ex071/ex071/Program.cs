using System;

namespace ex071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //71.Write a C# Sharp program to create a new string using the two middle characters of a given string of even length (at least 2).

            //Sample Input:
            //"Hell"
            //"JS"
            //Expected Output:
            //el
            //JS

            Console.WriteLine(middleCharsStr("Hell"));
            Console.WriteLine(middleCharsStr("JS"));
            Console.WriteLine(middleCharsStr("Henrique"));
        }

        public static string middleCharsStr(string str)
        {
            int middleInd = str.Length / 2;
            return str.Length > 2 ? str.Substring(middleInd - 1, middleInd) : str;
        }
    }
}
