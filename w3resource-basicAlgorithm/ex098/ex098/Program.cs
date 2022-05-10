using System;
using System.Linq;

namespace ex098
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //98.Write a C# Sharp program to check if a given array of integers and length 2, does not contain 15 or 20.

            //Sample Input:
            //{ 12, 20 }
            //{ 14, 15 }
            //{ 11, 21 }
            //Expected Output :
            //False
            //False
            //True

            Console.WriteLine(notFifteenOrTwentyRange(new[] { 12, 20}));
            Console.WriteLine(notFifteenOrTwentyRange(new[] { 14, 15}));
            Console.WriteLine(notFifteenOrTwentyRange(new[] { 11, 21}));
        }

        public static bool notFifteenOrTwentyRange(int[] numberArr)
        {
            return numberArr.Length == 2 && numberArr.Any(x => x == 15 || x == 20) ? false : true;
        }
    }
}
