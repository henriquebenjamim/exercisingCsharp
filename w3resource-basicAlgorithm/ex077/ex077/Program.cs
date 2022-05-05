using System;

namespace ex077
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //77.Write a C# Sharp program to create a new string taking the first character from a given string and the last character from another given string.
            //If the length of any given string is 0, use '#' as its missing character.

            //Sample Input:
            //"Hello", "Hi"
            //"Python", "PHP"
            //"JS", "JS"
            //"Csharp", ""
            //Expected Output:
            //Hi
            //PP
            //JS
            //C#

            Console.WriteLine(firstLast("Hello", "Hi"));
            Console.WriteLine(firstLast("Python", "PHP"));
            Console.WriteLine(firstLast("JS", "JS"));
            Console.WriteLine(firstLast("Csharp", ""));
        }

        public static string firstLast(string str1, string str2)
        {
            return str1.Length >= 1 && str2.Length >= 1 ? str1.Substring(0, 1) + str2.Substring(str2.Length -1) : 
                str1.Length < 1 ? "#" : 
                str2.Length < 1 ? str1.Substring(0, 1) + "#" : "";
        }
    }
}
