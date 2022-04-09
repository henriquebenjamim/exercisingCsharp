using System;

namespace ex037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //37.Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".
            //Test Data: PHP Tutorial
            //Sample Output:
            //P Tutorial

            Console.Write("Type something: ");
            string phrase = Console.ReadLine();

            if(phrase.Substring(1, 2) == "HP")
            {
                Console.WriteLine($"{phrase.Substring(0, 1)}{phrase.Substring(3)}");
            }

        }
    }
}
