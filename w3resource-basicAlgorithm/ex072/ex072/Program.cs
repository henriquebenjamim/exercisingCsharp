using System;

namespace ex072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //72.Write a C# Sharp program to check if a given string ends with "on". Go to the editor

            //Sample Input:
            //"Hello"
            //"Python"
            //"on"
            //"o"

            //Expected Output:
            //False
            //True
            //True
            //False

            Console.WriteLine(onInTheEnd("Hello"));
            Console.WriteLine(onInTheEnd("Python"));
            Console.WriteLine(onInTheEnd("on"));
            Console.WriteLine(onInTheEnd("o"));
        }

        public static bool onInTheEnd(string str)
        {
            return str.Length >= 2 && str.Substring(str.Length - 2) == "on" ? true : false; 
        }
    }
}
