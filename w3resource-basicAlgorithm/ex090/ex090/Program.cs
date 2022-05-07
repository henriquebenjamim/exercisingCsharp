using System;

namespace ex090
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //90.Write a C# Sharp program to check two given arrays of integers of length 1 or more and return true if they have the same first element
            //or they have the same last element.

            //Sample Input:
            //{ 10, 20, 40, 50 }, { 10, 20, 40, 50 }
            //{ 10, 20, 40, 50 }, { 10, 20, 40, 5 }
            //{ 10, 20, 40, 50 }, { 1, 20, 40, 5 }
            //Expected Output:
            //True
            //True
            //False

            Console.WriteLine(firstLastElementsEquals(new[] {10, 20, 40, 50}, new[] {10, 20, 40, 50}));
            Console.WriteLine(firstLastElementsEquals(new[] { 10, 20, 40, 50}, new[] { 10, 20, 40, 5}));
            Console.WriteLine(firstLastElementsEquals(new[] { 10, 20, 40, 50}, new[] { 1, 20, 40, 5}));
        }

        public static bool firstLastElementsEquals(int[] firstArr, int[] secondArr)
        {
            return firstArr.Length > 1 && secondArr.Length > 1 ? 
                firstArr[0] == secondArr[0] || firstArr[firstArr.Length - 1] == secondArr[secondArr.Length - 1] ?
                true : false : false;
        }
    }
}
