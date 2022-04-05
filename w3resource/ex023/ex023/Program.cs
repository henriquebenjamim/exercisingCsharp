using System;

namespace ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //23.Write a C# program to convert a given string into lowercase. Go to the editor
            //Sample Output:
            //write a c# sharp program to display the following pattern using the alphabet.

            Console.Write("Type some words: ");
            string phrase = Console.ReadLine();

            Console.WriteLine(phrase.ToLower());


        }
    }
}
