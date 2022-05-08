using System;
using System.Linq;

namespace ex097
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //97.Write a C# Sharp program to check if a given array of integers and length 2, contains 15 or 20.

            //Sample Input:
            //{ 12, 20 }
            //{ 14, 15 }
            //{ 11, 21 }
            //Expected Output :
            //True
            //True
            //False

            Console.WriteLine(fifteenOrTwentyRange(new[] { 12, 20}));
            Console.WriteLine(fifteenOrTwentyRange(new[] { 14, 15}));
            Console.WriteLine(fifteenOrTwentyRange(new[] { 11, 21}));
        }

        public static bool fifteenOrTwentyRange(int[] numberArr)
        {
            return numberArr.Length == 2 && numberArr.Any(x => x == 15 || x == 20);
        }
    }
}
