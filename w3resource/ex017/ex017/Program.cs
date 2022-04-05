using System;

namespace ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //17.Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back. Go to the editor
            //Sample Output:
            //Input a string : The quick brown fox jumps over the lazy dog.
            //TThe quick brown fox jumps over the lazy dog.T

            Console.Write("Input a string: ");
            string s = Console.ReadLine();

            Console.WriteLine(addingString(s));

        }

        public static string addingString(string phrase)
        {
            return phrase.Length > 1 ? phrase.Substring(0, 1) + phrase + phrase.Substring(0, 1) : phrase;
        }
    }
}
