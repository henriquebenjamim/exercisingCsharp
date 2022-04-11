using System;

namespace ex056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //56.Write a C# program to check if a given string is a palindrome or not.
            //Sample Example:
            //For 'aaa' the output should be true
            //For 'abcd' the output should be false

            Console.WriteLine("Give me a string: ");
            string phrase = Console.ReadLine();
            char[] arrPhrase = phrase.ToCharArray();
            Array.Reverse(arrPhrase);
            Console.WriteLine(arrPhrase);

            Console.WriteLine(new string(arrPhrase).Equals(phrase));
            //char[] reversedPhrase = new char[arrPhrase.Length];
            //int counting = arrPhrase.Length;

            //for (int i = 0 ; i < arrPhrase.Length; i++)
            //{
            //    reversedPhrase[counting -1] = arrPhrase[i];
            //    counting -= 1;
            //}
            //Console.WriteLine(new string(arrPhrase).Equals(reversedPhrase));
            
        }
    }
}
