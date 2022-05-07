using System;

namespace ex085
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //85.Write a C# Sharp program to create a new string from a given string without the first two characters.
            //Keep the first character if it is "p" and keep the second character if it is "y".

            //Sample Input:
            //"abcab"
            //"python"
            //"press"
            //"jython"
            //Expected Output:
            //cab
            //python
            //pess
            //ython

            Console.WriteLine(firstPSecondY("abcab"));
            Console.WriteLine(firstPSecondY("python"));
            Console.WriteLine(firstPSecondY("press"));
            Console.WriteLine(firstPSecondY("jython"));
        }

        public static string firstPSecondY(string str)
        {
            return str.Length > 2 && (str.Substring(0, 1) == "p" && str.Substring(1, 1) == "y") ? str: 
                str.Substring(0, 1) == "p" ? str.Substring(0, 1) + str.Substring(2) :
                str.Substring(1, 1) == "y" ? str.Substring(1) : str.Substring(2);

        }
    }
}
