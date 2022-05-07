using System;

namespace ex088
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //88.Write a C# Sharp program to check a given array of integers of length 1 or more and return true if
            //10 appears as either first or last element in the given array.

            //Sample Input:
            //{ 10, 20, 40, 50 }
            //{ 5, 20, 40, 10 }
            //{ 10, 20, 40, 10 }
            //{ 12, 24, 35, 55 }
            //Expected Output:
            //True
            //True
            //True
            //False

            Console.WriteLine(tenInArray(new[] { 10, 20, 40, 50}));
            Console.WriteLine(tenInArray(new[] { 5, 20, 40, 10}));
            Console.WriteLine(tenInArray(new[] { 10, 20, 40, 10}));
            Console.WriteLine(tenInArray(new[] { 12, 24, 35, 55}));
        }

        public static bool tenInArray(int[] numberArr)
        {
            return numberArr.Length > 1 ? numberArr[0] == 10 || numberArr[numberArr.Length - 1] == 10 ? true : false : false;
        }
    }
}
