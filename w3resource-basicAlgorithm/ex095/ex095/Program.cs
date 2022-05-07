using System;

namespace ex095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //95.Write a C# Sharp program to create a new array containing the middle elements from the two given arrays of integers, each length 5.

            //Sample Input:
            //{ 10, 20, -30, -40, 30 }, { 10, 20, 30, 40, 30 }
            //Expected Output:
            //New array: -30 30

            Console.WriteLine(maxAndMinArr(new[] { 10, 20, -30, -40, 30 }, new[] { 10, 20, 30, 40, 30}));
        }

        public static string maxAndMinArr(int[] firstArr, int[] secondArr)
        {
            return firstArr.Length == 5 && secondArr.Length == 5 ? $"New array: {firstArr[2]} {secondArr[2]}" : "Each array needs to have 'five' lenght";
        }
    }
}
