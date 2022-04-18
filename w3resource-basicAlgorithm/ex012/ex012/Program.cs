using System;

namespace ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12.Write a C# Sharp program to check if a given string starts with 'C#' or not. Go to the editor

            //Sample Input:
            //"C# Sharp"
            //"C#"
            //"C++"
            //Expected Output:
            //True
            //True
            //False
            Console.WriteLine(checkCsharpStart("C# Sharp"));
            Console.WriteLine(checkCsharpStart("C#"));
            Console.WriteLine(checkCsharpStart("C++"));
            Console.WriteLine(checkCsharpStart("c# it's the language that i'm using"));
        }

        public static bool checkCsharpStart(string str)
        {
            return str.Length >= 2 ? (str[0] == 'C' || str[0] == 'c') && str[1] == '#' ? true : false : false; 
        }
    }
}
