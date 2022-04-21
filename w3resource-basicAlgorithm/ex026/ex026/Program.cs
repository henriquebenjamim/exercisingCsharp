using System;
using System.Linq;

namespace ex026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //26.Write a C# Sharp program to create a new string which is n (non-negative integer) copies of the the first 3 characters of a given string. If the length of the given string is less than 3 then return n copies of the string.

            //Sample Input:
            //"Python", 2
            //"Python", 3
            //"JS", 3
            //Expected Output:
            //PytPyt
            //PytPytPyt
            //JSJSJS

            Console.WriteLine(newSt("Python", 2));
            Console.WriteLine(newSt("Python", 3));
            Console.WriteLine(newSt("js", 3));
        }

        public static string newSt(string str, int numbersRepeating)
        {
            string result = String.Empty;
            var frontStrings = 3;

            if(frontStrings > str.Length)
            {
                frontStrings = str.Length;
            }

            var front = str.Substring(0, frontStrings);

            for(var i = 0; i < numbersRepeating; i ++)
            {
                result += front;
            }

            return result;
        }
    }

}
