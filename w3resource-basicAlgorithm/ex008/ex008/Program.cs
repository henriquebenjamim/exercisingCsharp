using System;

namespace ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8.Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string. Go to the editor

            //Sample Input:
            //"C Sharp"
            //"JS"
            //"a"
            //Expected Output:
            //C C C C
            //JSJSJSJS
            //a

            string name = "henrique";
            Console.WriteLine(name.Substring(0, 2) + name.Substring(0, 2));

        }

        public static string fourCopiesString(string str)
        {
            return str.Length == 1 ? str : str.SubString(0, 2) + str.SubString(0, 2) + str.SubString(0, 2) + str.SubString(0, 2)
        }
    }
}
