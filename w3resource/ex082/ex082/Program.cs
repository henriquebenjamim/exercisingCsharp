using System;
using System.Text;

namespace ex082
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //82.Write a C# Sharp program to remove all characters which are non-letters from a given string.
            //From Wikipedia,
            //A letter is a segmental symbol of a phonemic writing system. The inventory of all letters forms the alphabet.
            //Letters broadly correspond to phonemes in the spoken form of the language, although there is rarely a consistent, exact correspondence between letters and phonemes
            //Sample Output:
            //Orginal string: Py @th12on
            //Remove all characters from the said string which are non-letters: Python
            //Orginal string: Python 3.0
            //Remove all characters from the said string which are non-letters: Python
            //Orginal string: 2 ^ sdfds * ^*^jlljdslfnoswje34u230sdfds984
            //Remove all characters from the said string which are non-letters: sdfdsjlljdslfnoswjeusdfds

            //065 - 090(A to Z)
            //097 - 122(a to z)

            Console.Write("Give me a string: ");
            string str = Console.ReadLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(str);
            
            foreach(byte value in asciiBytes)
            {
                if((value >= 65 && value <= 90) || (value >= 97 && value <= 122))
                {
                    Console.Write(Convert.ToChar(value));
                }
            }
        }
    }
}
