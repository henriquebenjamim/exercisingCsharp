using System;

namespace ex078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //78.Write a C# Sharp program to find sum of squares of elements of a given array of integers.
            //Sample Output:
            //Sum of squares of elements of the said array: 14
            //Sum of squares of elements of the said array: 29

            int[] numbers = { 1, 2, 3 };
            int[] numbersTwo = { 2, 3, 4 };

            Console.WriteLine(squareElementsArray(numbers));
            Console.WriteLine(squareElementsArray(numbersTwo));
        }

        public static string squareElementsArray(int[] arr)
        {
            int amount = 0;
            foreach(int value in arr)
            {
                amount += value * value;
            }

            return $"Sum of squares of elements of the said array: {amount}";
        }
    }
}
