using System;

namespace ex024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //24.Write a C# program to find the longest word in a string.
            //Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
            //Sample Output:
            //following

            Console.Write("Type a phrase: ");
            string phrase = Console.ReadLine();

            string[] splittingWords = phrase.Split(" ");
            string mostWord = "";
            int lengWord = 0;
            foreach (string words in splittingWords)
            {   
                if(words.Length > lengWord)
                {   
                    
                    mostWord = words;
                    lengWord = words.Length;
                }
            }
            Console.WriteLine(mostWord);
            

        }
    }
}
