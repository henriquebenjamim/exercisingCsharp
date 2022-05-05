using System;

namespace ex080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //80.Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'.
            //If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return the empty string.

            //Sample Input:
            //"abc"
            //"abcdef"
            //"C"
            //"xyz"
            //"xyzsder"
            //Expected Output:
            //abc
            //abc

            //xyz
            //xyz

            Console.WriteLine(revertingStr("abc"));
            Console.WriteLine(revertingStr("abcdef"));
            Console.WriteLine(revertingStr("C"));
            Console.WriteLine(revertingStr("xyz"));
            Console.WriteLine(revertingStr("xyzsder"));
        }

        public static string revertingStr(string str)
        {
            return str.Length >=3 && str.Substring(0, 3) == "abc" ? "abc" :
                str.Length >= 3 && str.Substring(0, 3) == "xyz" ? "xyz" : "";
        }
    }
}
