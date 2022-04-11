using System;

namespace ex053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //53.Write a C# program to check if an array contains an odd number.
            //Test Data:
            //Original array: [2, 4, 7, 8, 6]
            //Check if an array contains an odd number? True

            int[] arrOne = { 2, 4, 7, 8, 6 };
            int[] arrTwo = { 6, 2, 4, 8, 16 };
            int[] arrThree = { 6, 3, 2, 4, 7 };

            Console.WriteLine(checkOddNumber(arrOne));
            Console.WriteLine(checkOddNumber(arrTwo));
            Console.WriteLine(checkOddNumber(arrThree));

        }

        public static bool checkOddNumber(int[] arr)
        {
            int countingOdds = 0;
            for(int i = 0; i < arr.Length -1; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    countingOdds += 1;
                }
            }
            return countingOdds > 0 ? true : false;
        }
    }
}
