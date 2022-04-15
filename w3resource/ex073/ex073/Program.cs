using System;
using System.Linq;

namespace ex073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //73.Write a C# Sharp program to convert the letters of a given string (same case-upper/lower) into alphabetical order.
            //Sample Output:
            //Original string: PHP
            //Convert the letters of the said string into alphabetical order: HPP
            //Original string: javascript
            //Convert the letters of the said string into alphabetical order: aacijprstv
            //Original string: python
            //Convert the letters of the said string into alphabetical order: hnopty

            Console.Write("Original string: ");
            string word = Console.ReadLine();
            char[] wordChar = word.ToCharArray();
            Array.Sort(wordChar);

            if (wordChar.All(x => char.IsUpper(x)))
            {
                foreach (char v in wordChar)
                {
                    Console.WriteLine(v);
                }
            }
            else if(wordChar.All(x => char.IsLower(x)))
            {
                foreach (char v in wordChar)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("This string need to be only in lowercase/upper");
            }
            
        }
    }
}
