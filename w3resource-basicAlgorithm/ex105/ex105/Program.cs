using System;

namespace ex105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //105.Write a C# Sharp program to create a new array swapping the first and last elements of a given array of integers and length will be least 1.

            //Sample Input:
            //{ 1, 5, 7, 9, 11, 13 }
            //Expected Output :
            //Original array: 1, 5, 7, 9, 11, 13
            //After swapping first and last elements: 13 5 7 9 11 1

            int[] originalNumbersArr = newArr(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("After swapping first n last elements: ");
            foreach (int value in originalNumbersArr)
            {
                Console.Write($"{value} ");
            }
        }

        public static int[] newArr(int[] numbersArr)
        {
            int substitute = numbersArr[0];
            numbersArr[0] = numbersArr[numbersArr.Length - 1];
            numbersArr[numbersArr.Length - 1] = substitute;

            return numbersArr;
        }
    }
}
