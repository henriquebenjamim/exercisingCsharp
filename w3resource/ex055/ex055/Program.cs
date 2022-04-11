using System;

namespace ex055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //55.Write a C# program to find the pair of adjacent elements that has the largest product of an given array which is equal to a given value.
            Console.WriteLine(adjacentPair(new int[] { 2, 4, 3, 5, 6, 7, 8, 9})); // 72

        }

        public static int adjacentPair(int[] arr)
        {
            int arrIndex = 0;
            int productElements = arr[arrIndex] * arr[arrIndex + 1];

            arrIndex++;
            while (arrIndex + 1 < arr.Length)
            {
                productElements = ((arr[arrIndex] * arr[arrIndex + 1]) > productElements) ?
                           (arr[arrIndex] * arr[arrIndex + 1]) :
                            productElements;
                arrIndex++;
            }

            return productElements;

        }
    }
}
