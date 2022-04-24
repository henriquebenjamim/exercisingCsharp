using System;

namespace ex035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //35.Write a C# Sharp program to compare two given strings and return the number of the positions where they contain the same length 2 substring.

            //Sample Input:
            //"abcdefgh", "abijsklm"
            //"abcde", "osuefrcd"
            //"pqrstuvwx", "pqkdiewx"
            //Expected Output:
            //1
            //1
            //2

            Console.Write("Give me the first string: ");
            string firstWord = Console.ReadLine();
            
            Console.Write("Give me the second string: ");
            string secondWord = Console.ReadLine();

            int counting = 0;
            for(int i = 0; i < firstWord.Length -1; i++)
            {
                string subWordOne = firstWord.Substring(i, 2);
                for(int j = 0; j < secondWord.Length -1; j++)
                {
                    string subWordTwo = secondWord.Substring(j, 2);
                    if(subWordOne.Equals(subWordTwo))
                    {
                        counting += 1;
                    }
                }
            }
            Console.WriteLine(counting);
        }
    }
}
