using System;
using System.Linq;

namespace ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //22.Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character. Go to the editor

            //Sample Input:
            //"frizz"
            //"zane"
            //"Zazz"
            //"false"
            //"zzzz"
            //"ZZZZ"

            //Expected Output:
            //True
            //False
            //True
            //False
            //True
            //False

            Console.WriteLine(countingZ("frizz"));
            Console.WriteLine(countingZ("zane"));
            Console.WriteLine(countingZ("Zazz"));
            Console.WriteLine(countingZ("false"));
            Console.WriteLine(countingZ("zzzz"));
            Console.WriteLine(countingZ("ZZZZ"));
        }

        public static bool countingZ(string str)
        {
            int countingLetterZ = str.Count(x => x == 'z');

            return (countingLetterZ >= 2 && countingLetterZ <= 4) ? true : false;
        }
    }
}
