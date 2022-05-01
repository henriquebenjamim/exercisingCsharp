using System;

namespace ex073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //73.Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n.

            //Sample Input:
            //"Hello", 1
            //"Python", 2
            //"on", 1
            //"o", 1
            //Expected Output:
            //Ho
            //Pyon
            //on
            //oo

            Console.WriteLine(nCharactersStr("Hello", 1));
            Console.WriteLine(nCharactersStr("Python", 2));
            Console.WriteLine(nCharactersStr("on", 1));
            Console.WriteLine(nCharactersStr("o", 1));
        }

        public static string nCharactersStr(string str, int quantityNumbers)
        {   
            
            string repeatedString = new string(str[0], quantityNumbers+1);
            return str.Length > 1? str.Substring(0, quantityNumbers ) + str.Substring(str.Length - quantityNumbers) : repeatedString;
        }
    }
}
