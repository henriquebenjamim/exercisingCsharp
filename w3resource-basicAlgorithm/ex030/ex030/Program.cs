using System;

namespace ex030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //30.Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd". Go to the editor

            //Sample Input:
            //"abcd"
            //"abc"
            //"a"
            //Expected Output:
            //aababcabcd
            //aababc
            //a

            string[] arrString = { "a", "ab", "abc", "abcd" };
            Console.Write("Give me a string: ");
            string word = Console.ReadLine();

            for(int i = 0; i <= word.Length -1; i++)
            {   
                
                if(arrString[i] == word)
                {
                    Console.Write(arrString[i]);
                    break;
                }
                else
                {
                    Console.Write(arrString[i]);
                }
            }
        }

    }
}
