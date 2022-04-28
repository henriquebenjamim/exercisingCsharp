using System;

namespace ex054
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //54.Write a C# Sharp program to compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x.
            //If the sum has more digits than x then return x without y.

            //Sample Input:
            //4, 5
            //7, 4
            //10, 10
            //Expected Output:
            //9
            //7
            //20

            Console.WriteLine(sumNonNegative(4, 5));
            Console.WriteLine(sumNonNegative(7, 4));
            Console.WriteLine(sumNonNegative(10, 10));
        }

        public static int sumNonNegative(int numberOne, int numberTwo)
        {
            return (numberOne + numberTwo).ToString().Length > numberOne.ToString().Length ? numberOne : numberOne + numberTwo;
        }
    }
}
