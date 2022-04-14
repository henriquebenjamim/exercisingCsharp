using System;
using System.Linq;

namespace ex068
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //68.Write a C# Sharp program to count a specified character (both cases) in a given string.

            string name = "hEnrique";
            int countingCharacterUpper = name.Count(x => x == 'E');
            int countingCharacterLower = name.Count(x => x == 'e');
            Console.WriteLine(countingCharacterUpper);
            Console.WriteLine(countingCharacterLower);
            Console.WriteLine(countingCharacterUpper + countingCharacterLower);
            Console.WriteLine(countingCharacters("Henrique EEA", 'E', 'e'));
        }

        public static int countingCharacters(string str, char characterUpper, char characterLower)
        {
            int countingCharacterUpper = str.Count(x => x == 'E');
            int countingCharacterLower = str.Count(x => x == 'e');
            return countingCharacterLower + countingCharacterUpper;
        }
    }
}
