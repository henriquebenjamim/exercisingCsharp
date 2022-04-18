using System;

namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9.Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more. Go to the editor

            //Sample Input:
            //"Red"
            //"Green"
            //"1"

            //Expected Output:
            //dRedd
            //nGreenn
            //111

            Console.WriteLine(addingCharacters("Red"));
            Console.WriteLine(addingCharacters("Green"));
            Console.WriteLine(addingCharacters("1"));

        }

        public static string addingCharacters(string str)
        {
            return str.Length >= 1 ? str[str.Length - 1] + str + str[str.Length - 1]: str;
        }
    }
}
