using System;
using System.Linq;

namespace ex083
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //83.Write a C# Sharp program to remove all vowels from a given string.
            //Sample Output:
            //Orginal string: Python
            //After removing all the vowels from the said string: Pythn
            //Orginal string: C Sharp
            //After removing all the vowels from the said string: C Shrp
            //Orginal string: JavaScript
            //After removing all the vowels from the said string: JvScrpt

            Console.Write("Give me a string: ");
            string word = Console.ReadLine();

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach(char c in word)
            {
                if(vowels.Contains(c))
                {
                    continue;
                }
                else
                {
                    Console.Write($"{c}");
                }
            }

        }
    }
}
