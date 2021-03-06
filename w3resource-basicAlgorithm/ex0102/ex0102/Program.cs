using System;

namespace ex0102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //102.Write a C# Sharp program to compute the sum of the two given arrays of integers,
            //length 3 and find the array which has the largest sum.

            //Sample Input:
            //{ 10, 20, -30 }, { 10, 20, 30 }
            //Expected Output :
            //Original array:  1, 5, 7
            //Larger array: 10 20 30

            int[] item = test(new[] { 10, 20, -30 }, new[] { 10, 20, 30 });
            Console.Write("Larger array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }

        public static int[] test(int[] numbersArrOne, int[] numbersArrTwo)
        {
            return numbersArrOne[0] + numbersArrOne[1] + numbersArrOne[2] >= numbersArrTwo[0] + numbersArrTwo[1] + numbersArrTwo[2] ? numbersArrOne : numbersArrTwo;
        }

    }
}
