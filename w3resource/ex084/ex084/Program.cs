using System;

namespace ex084
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //84.Write a C# Sharp program to get the index number of all lower case letters in a given string.
            //Sample Output:
            //Orginal string: Python
            //Indices of all lower case letters of the said string:
            //1 2 3 4 5
            //Orginal string: JavaScript
            //Indices of all lower case letters of the said string:
            //1 2 3 5 6 7 8 9

            Console.WriteLine("Give me a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Indices of all lower case letters of the said string: ");
            foreach(char value in str)
            {   
                
                if(Char.IsLower(value))
                {
                    Console.Write(str.IndexOf(value)+ " ");
                }
            }
        }
    }
}
