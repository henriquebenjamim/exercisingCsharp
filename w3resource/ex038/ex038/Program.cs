using System;

namespace ex038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //38.Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH".
            //Test Data: PHP
            //Sample Output: PH

            Console.Write("Type a string phrase: ");
            string phrase = Console.ReadLine();

            if(phrase.Substring(0, 2) == "PH")
            {
                Console.WriteLine(phrase.Substring(0, 2));
            }

        }
    }
}
