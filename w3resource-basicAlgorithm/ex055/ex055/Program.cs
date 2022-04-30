using System;

namespace ex055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //55.Write a C# Sharp program to compute the sum of three given integers. If the two values are same return the third value.

            //Sample Input:
            //4, 5, 7
            //7, 4, 12
            //10, 10, 12
            //12, 12, 18
            //Expected Output:
            //16
            //23
            //12
            //18

            Console.WriteLine(tripleSum(4, 5, 7));
            Console.WriteLine(tripleSum(7, 4, 12));
            Console.WriteLine(tripleSum(10, 10, 12));
            Console.WriteLine(tripleSum(12, 12, 18));
        }

        public static int tripleSum(int numberOne, int numberTwo, int numberThree)
        {
            bool tripleCondition = (numberOne == numberTwo) || (numberOne == numberThree) || (numberThree == numberTwo);
            int sum = numberOne + numberTwo + numberThree;
            return tripleCondition ? numberThree : sum;
        }
    }
}
