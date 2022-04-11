using System;

namespace ex057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //57.Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers.

            Console.WriteLine(adjacentElements(new int[] { 1, -3, 4, -5, 1 }));
            Console.WriteLine(adjacentElements(new int[] { 1, 3, 4, 5, 2 }));
            Console.WriteLine(adjacentElements(new int[] { 1, 3, -4, 5, 2 }));
            Console.WriteLine(adjacentElements(new int[] { 1, 0, -4, 0, 2 }));
        }

        public static int adjacentElements(int[] arr)
        {
            int maximumValue = arr[0] * arr[1];
            for (int x = 1; x < arr.Length - 1; x++)
            {
                maximumValue = Math.Max(maximumValue, arr[x] * arr[x + 1]);
            }
            return maximumValue;
        }
    }
}
