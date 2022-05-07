using System;
using System.Linq;

namespace ex094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //94.Write a C# Sharp program to find out the maximum element between the first or last element in a given array of integers ( length 4), replace all elements with maximum element.

            //Sample Input:
            //{ 10, 20, -30, -40 }
            //Expected Output:
            //New array: 20 20 20 20

            Console.WriteLine(maximumRepeated(new[] { 10, 20, -30, -40}));
        }

        public static string maximumRepeated(int[] numbersArr)
        {
            return $"New array: {numbersArr.Max()} {numbersArr.Max()} {numbersArr.Max()} {numbersArr.Max()}";
        }
    }
}
