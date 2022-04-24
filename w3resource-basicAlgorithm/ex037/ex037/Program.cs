using System;
using System.Linq;

namespace ex037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //37.Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.

            //Sample Input:
            //"Python"
            //"JavaScript"
            //"HTML"
            //Expected Output:
            //Pyon
            //JaScpt
            //HT

            Console.WriteLine(creatingSpecificString("Python"));
            Console.WriteLine(creatingSpecificString("Henrique"));
            Console.WriteLine(creatingSpecificString("JavaScript"));
            Console.WriteLine(creatingSpecificString("HTML"));
        }

        public static string creatingSpecificString(string str)
        {
            int[] indexArr = { 0, 1, 4, 5, 8, 9 };
            var newStr = string.Empty;

            for(int i = 0; i <= str.Length -1; i++)
            {
                if (indexArr.Contains(str.IndexOf(str[i])))
                {
                    newStr += str[i];  
                }
            }

            return newStr;
        }
    }
}
