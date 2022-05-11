using System;
using System.Linq;

namespace ex100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //100.Write a C# Sharp program to check a given array of integers and return true if the array contains 10 or 20 twice.
            //The length of the array will be 0, 1, or 2.

            //Sample Input:
            //{ 12, 20 }
            //{ 20, 20 }
            //{ 10, 10 }
            //{ 10 }
            //Expected Output :
            //False
            //True
            //True
            //False

            Console.WriteLine(tenOrTwentyTwice(new[] { 12, 20}));
            Console.WriteLine(tenOrTwentyTwice(new[] { 20, 20}));
            Console.WriteLine(tenOrTwentyTwice(new[] { 10, 10}));
            Console.WriteLine(tenOrTwentyTwice(new[] { 10 }));
        }

        public static bool tenOrTwentyTwice(int[] numbersArr)
        {
            return numbersArr.Length >= 2 && (numbersArr.Count(x => x == 10) == 2 || numbersArr.Count(x => x == 20) == 2);
        }
    }
}
