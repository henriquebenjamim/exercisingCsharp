using System;

namespace ex104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //104.Write a C# Sharp program to create a new array from two give array of integers, each length 3.

            //Sample Input:
            //{ 10, 20, 30 }, { 40, 50, 60 }
            //Expected Output :
            //Array 1: 10, 20, 30
            //Array 2: 40, 50, 60
            //New array: 10 20 30 40 50 60

            int[] newArr = newNumberArr(new[] { 10, 20, 30 }, new[] { 40, 50, 60 });
            Console.Write("New array: ");
            foreach (int value in newArr)
            {
                Console.Write($"{value} ");
            }
        }

        public static int[] newNumberArr(int[] numberOneArr, int[] numberTwoArr)
        {
            return new int[] { numberOneArr[0], numberOneArr[1], numberOneArr[2], numberTwoArr[0], numberTwoArr[1], numberTwoArr[2] };
        }
    }
}
