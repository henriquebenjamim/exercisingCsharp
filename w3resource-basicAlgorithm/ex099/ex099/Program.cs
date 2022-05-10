using System;
using System.Linq;

namespace ex099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //99.Write a C# Sharp program to create a new array of integers and length 1 or more.
            //The length of the new array will be double length of the given array and all the elements
            //are 1 except the first element which is equal to the given array.

            //Sample Input:
            //{ 10, 20, -30, -40, 30 }
            //Expected Output :
            //New array: 10 0 0 0 0 0 0 0 0 0

            Console.WriteLine(onlyFirstNormal(new[] { 10, 20, -30, -40, 30}));
        }

        public static string onlyFirstNormal(int[] number)
        {
            int rep = number.Length * 2 - 1;
            return number.Length >= 1 ? $"New array: {number[0]} {string.Concat(Enumerable.Repeat("0 ", rep))}" : $"We don't have any value.";
        }
    }
}
