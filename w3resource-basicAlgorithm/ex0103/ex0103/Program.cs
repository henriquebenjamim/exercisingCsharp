using System;

namespace ex0103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //103.Write a C# Sharp program to create an array taking two middle elements from a given array of integers of length even.

            //Sample Input:
            //{ 1, 5, 7, 9, 11, 13 }
            //Expected Output:
            //Original array: 1, 5, 7, 9, 11, 13
            //New array: 7 9

            Console.WriteLine(numbersMiddleArr(new[] { 1, 5, 7, 9, 11, 13}));
        }

        public static string numbersMiddleArr(int[] numbersArr)
        {
            return numbersArr.Length % 2 != 0 ? $"I can't do this, lenght array is odd" : $"New array: {numbersArr[numbersArr.Length / 2 - 1]} {numbersArr[numbersArr.Length / 2]}";
        }
    }
}
