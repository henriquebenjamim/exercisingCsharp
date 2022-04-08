using System;

namespace ex032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //32.Write a C# program to create a new string of four copies, taking last four characters from a given string.
            //If the length of the given string is less than 4 return the original one.
            //Sample Output:
            //Input a string : The quick brown fox jumps over the lazy dog.
            //dog.dog.dog.dog.

            Console.Write("Input a string: ");
            string phrase = Console.ReadLine();
            string[] phraseArr = phrase.Split(' ');
            
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{phraseArr[phraseArr.Length -1]}");
            }

        }
    }
}
