using System;

namespace ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15.Write a C# program remove specified a character from a non-empty string using index of a character. Go to the editor
            //Test Data:
            //w3resource
            //Sample Output:
            //wresource
            //w3resourc
            //3resource

            Console.WriteLine(removingChars("w3resource", 1));
            Console.WriteLine(removingChars("w3resource", 9));
            Console.WriteLine(removingChars("w3resource", 0));


        }
        public static string removingChars(string word, int numberIndex)
        {   
            // now i know to use this on same problems
            return word.Remove(numberIndex, 1);
        }
    }

    
}
