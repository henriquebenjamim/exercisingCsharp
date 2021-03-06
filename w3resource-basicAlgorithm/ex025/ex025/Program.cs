using System;
using System.Linq;

namespace ex025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //25.Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string. Go to the editor

            //Sample Input:
            //"JS", 2
            //"JS", 3
            //"JS", 1
            //Expected Output:
            //JSJS
            //JSJSJS
            //JS

            Console.WriteLine(repStr("JS", 2));
            Console.WriteLine(repStr("JS", 3));
            Console.WriteLine(repStr("JS", 1));
        }

        public static string repStr(string str, int numberRep)
        {   
            return string.Concat(Enumerable.Repeat(str, numberRep));
        }
    }
}
