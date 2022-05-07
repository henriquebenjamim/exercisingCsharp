using System;

namespace ex089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //89.Write a C# Sharp program to check a given array of integers of length 1 or more and return true if the first element and
            //the last element are equal in the given array.

            //Sample Input:
            //{ 10, 20, 40, 50 }
            //{ 10, 20, 40, 10 }
            //{ 12, 24, 35, 55 }
            //Expected Output:
            //False
            //True
            //False

            Console.WriteLine(firstLastEqualsArr(new[] { 10, 20, 40, 50}));
            Console.WriteLine(firstLastEqualsArr(new[] { 10, 20, 40, 10}));
            Console.WriteLine(firstLastEqualsArr(new[] { 12, 24, 35, 55}));
        }

        public static bool firstLastEqualsArr(int[] numberArr)
        {
            return numberArr.Length > 1 ? numberArr[0] == numberArr[numberArr.Length - 1] ? true : false : false;
        }
    }
}
