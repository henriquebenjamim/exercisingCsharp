using System;

namespace ex024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //24.Write a C# Sharp program to convert the last 3 characters of a given string in upper case. If the length of the string has less than 3 then uppercase all the characters. Go to the editor

            //Sample Input:
            //"Python"
            //"Javascript"
            //"js"
            //"PHP"
            //Expected Output:
            //PytHON
            //JavascrIPT
            //JS
            //PHP

            Console.WriteLine(someUpper("Python"));
            Console.WriteLine(someUpper("Javascript"));
            Console.WriteLine(someUpper("js"));
            Console.WriteLine(someUpper("PHP"));

        }

        public static string someUpper(string str)
        {
            int cutting = str.Length - 3;
            return str.Length >= 3 ? str.Substring(0, cutting) + str.Substring(cutting).ToUpper() : str.ToUpper();
        }
    }
}
