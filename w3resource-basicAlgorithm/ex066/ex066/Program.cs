using System;

namespace ex066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //66.Write a C# Sharp program to create a new string from two given string one is shorter and another is longer. The format of the new string will be long string + short string + long string. Go to the editor

            //Sample Input:
            //"Hello", "Hi"
            //"JS", "Python"
            //Expected Output:
            //HelloHiHello
            //PythonJSPython

            Console.WriteLine(biggerLowerbigger("Hello", "Hi"));
            Console.WriteLine(biggerLowerbigger("JS", "Python"));
        }

        public static string biggerLowerbigger(string firstStr, string secondStr)
        {
            return firstStr.Length >= secondStr.Length ? $"{firstStr}{secondStr}{firstStr}" : $"{secondStr}{firstStr}{secondStr}";
        }
    }
}
