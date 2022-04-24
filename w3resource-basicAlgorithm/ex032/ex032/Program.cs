using System;
using System.Linq;

namespace ex032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //32.Write a C# Sharp program to check a specified number is present in a given array of integers.

            //Sample Input:
            //{ 1,2,9,3}, 3
            //{ 1,2,2,3}, 2
            //{ 1,2,2,3}, 9
            //Expected Output:
            //True
            //True
            //False

            int[] numberOneArr = { 1, 2, 9, 3 };
            int[] numberTwoArr = { 1, 2, 2, 3 };
            int[] numberThreeArr = { 1, 2, 2, 3 };

            Console.WriteLine(checkNumber(numberOneArr, 3));
            Console.WriteLine(checkNumber(numberTwoArr, 2));
            Console.WriteLine(checkNumber(numberThreeArr, 9));

        }

        public static bool checkNumber(int[] arrNumbers, int number)
        {
            return arrNumbers.Contains(number) ? true : false;
        }
    }
}
