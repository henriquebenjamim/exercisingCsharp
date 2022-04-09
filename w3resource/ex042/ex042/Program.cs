using System;

namespace ex042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //42.Write a C# program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case.
            //Test Data:
            //Input a string: w3r
            //Sample Output: W3R

            Console.Write("Input a string: ");
            string wordString = Console.ReadLine();
            Console.WriteLine(differentStr(wordString));

            // if > 4char || string.toLower(substring(0, 3) : string.toUpper()
            
        }

        public static string differentStr(string word)
        {
            if (word.Length > 4)
            {
                string cuttingWord = word.Substring(0, 3);
                return cuttingWord.ToLower() + word.Substring(3);
            }
            else
            {
                return word.ToUpper();
            }
                
        }
    }
}
