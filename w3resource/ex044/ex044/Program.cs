using System;

namespace ex044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //44.Write a C# program to create a new string of every other character (odd position) from the first position of a given string.
            //Test Data:
            //Input a string : w3resource
            //Sample Output:
            //wrsuc

            Console.Write("Input a string: ");
            string word = Console.ReadLine();
            for(int i=0; i <= word.Length - 1; i++)
            {
                if(i % 2 != 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(word[i]);
                }
            }

        }
    }
}
