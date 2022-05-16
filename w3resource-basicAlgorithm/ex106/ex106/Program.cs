using System;

namespace ex106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //106.Write a C# Sharp program to create a new array length 3 from a given array (length at least 3) using the elements from the middle of the array.

            //Sample Input:
            //{ 1, 5, 7, 9, 11, 13 }
            //Expected Output :

            //Original array: 1, 5, 7, 9, 11, 13
            //New array: 7 9 11

            int[] arr = numberArr(new[] { 1, 5, 7, 9, 11, 13 });
            Console.WriteLine("New array: ");
            foreach (int value in arr)
            {
                Console.Write($"{value} ");
            }
        }

        public static int[] numberArr(int[] numbers)
        {
            return new int[] { numbers[numbers.Length / 2 - 1], numbers[numbers.Length / 2], numbers[numbers.Length / 2 + 1] };
        }
    }
}
