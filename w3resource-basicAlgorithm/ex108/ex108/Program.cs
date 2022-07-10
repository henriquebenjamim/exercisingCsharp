using System;

namespace ex108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //108.Write a C# Sharp program to create a new array taking the first two elements from a given array.
            //If the length of the given array is less than 2 then return the give array.

            //Sample Input:
            //{ 1, 5, 7, 9, 11, 13 }
            //Expected Output :
            //New array: 1 5

            int[] exampleArray = gettingTwoFirstOnArray(new[] { 1, 2, 3, 4, 5, 6 });
            int[] exampleArray2 = gettingTwoFirstOnArray(new[] { 1, 5, 7, 9, 11, 13 });
            int[] exampleArray3 = gettingTwoFirstOnArray(new[] { 9 });

            foreach (var example in exampleArray)
            {
                Console.Write($"{example.ToString()} ");
            }
            foreach (var example in exampleArray2)
            {
                Console.Write($"{example.ToString()} ");
            }
            foreach (var example in exampleArray3)
            {
                Console.Write($"{example.ToString()} ");
            }

        }

        static int[] gettingTwoFirstOnArray(int[] numberArray)
        {
            int[] numbersToGet;

            if (numberArray.Length >= 2)
            {
                numbersToGet = new int[] { numberArray[0], numberArray[1] };
            }
            else if(numberArray.Length > 0)
            {
                numbersToGet = new int[] { numberArray[0] };
            }
            else
            {
                numbersToGet = new int[0];
            }

            return numbersToGet;
        }
    }
}
