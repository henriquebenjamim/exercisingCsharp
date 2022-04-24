using System;

namespace ex039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //39.Write a C# Sharp program to check if a triple is presents in an array of integers or not. If a value appears three times in a row in an array it is called a triple.

            //Sample Input:
            //{ 1, 1, 2, 2, 1 }
            //{ 1, 1, 2, 1, 2, 3 }
            //{ 1, 1, 1, 2, 2, 2, 1 }
            //Expected Output:
            //False
            //False
            //True

            Console.WriteLine(tripleRow(new[] {1, 1, 2, 2, 1}));
            Console.WriteLine(tripleRow(new[] { 1, 1, 2, 1, 2, 3}));
            Console.WriteLine(tripleRow(new[] { 1, 1, 1, 2, 2, 2, 1}));
        }

        public static bool tripleRow(int[] numbersArr)
        {
            int countingTriples = 0;

            for (int i = 0; i <= numbersArr.Length - 3; i++)
            {
                if(numbersArr[i] == numbersArr[i+1] && numbersArr[i+1] == numbersArr[i+2])
                {
                    countingTriples += 1;
                }
            }
            return countingTriples >= 1 ? true : false;
        }
    }
}
