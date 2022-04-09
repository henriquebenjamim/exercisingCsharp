using System;

namespace ex041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //41.Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.
            //Test Data:
            //Input a string(contains at least one 'w' char) : w3resource
            //Test the string contains 'w' character between 1 and 3 times:
            //            Sample Output
            //True

            Console.Write("Input a tring(Contains at least one 'w' char): ");
            string word = Console.ReadLine();

            char[] wordArr = word.ToCharArray();
            int countingW = 0;
            foreach(char character in wordArr)
            {
                if(character == 'w')
                {
                    countingW += 1;
                }
            }
            Console.WriteLine(countingW >= 1 && countingW <= 3);
        }
    }
}
