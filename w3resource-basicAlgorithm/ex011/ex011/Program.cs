using System;

namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11.Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there. Go to the editor

            //Sample Input:
            //"Python"
            //"JS"
            //"Code"
            //Expected Output:
            //PytPythonPyt
            //JSJSJS
            //CodCodeCod

            Console.WriteLine(addingThreeCharacters("Python"));
            Console.WriteLine(addingThreeCharacters("JS"));
            Console.WriteLine(addingThreeCharacters("Code"));

        }

        public static string addingThreeCharacters(string str)
        {
            return str.Length < 3 ? str + str + str : str.Substring(0, 3) + str + str.Substring(0, 3);
        }
    }
}
