using System;
using System.Linq;

namespace ex091
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //91.Write a C# Sharp program to compute the sum of the elements of an given array of integers.

            //Sample Input:
            //{ 10, 20, 30, 40, 50 }
            //{ 10, 20, -30, -40, 50 }
            //Expected Output:
            //150
            //10

            Console.WriteLine(sumArr(new[] { 10, 20, 30, 40, 50}));
            Console.WriteLine(sumArr(new[] { 10, 20, -30, -40, 50}));
        }

        public static int sumArr(int[] numbersArr)
        {
            return numbersArr.Sum(x => x);
        }
    }
}
