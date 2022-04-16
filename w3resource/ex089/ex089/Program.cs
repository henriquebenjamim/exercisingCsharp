using System;

namespace ex089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //89.Write a C# Sharp program to count positive and negative numbers in a given array of integers.
            //Sample Output:
            //Original Array elements: 10 - 11 12 - 13 14 - 18 19 - 20
            //Number of positive numbers: 4
            //Number of negative numbers: 4
            //Original Array elements: -4 - 3 - 2 0 3 5 6 2 6
            //Number of positive numbers: 5
            //Number of negative numbers: 3
            //Original Array elements:
            //Number of positive numbers: 0
            //Number of negative numbers: 0
            int[] firstArr = { 10, -11, 12, -13, 14, -18, 19, -20 };
            int[] secondArr = { -4, -3, -2, 0, 3, 5, 6, 2, 6 };
            int[] emptyArr = { };

            Console.WriteLine(amountPositiveNegative(firstArr));
            Console.WriteLine();

            Console.WriteLine(amountPositiveNegative(secondArr));
            Console.WriteLine();

            Console.WriteLine(amountPositiveNegative(emptyArr));
            Console.WriteLine();
        }

        public static string amountPositiveNegative(int[] arrNumbers)
        {
            int negativeNumbers = 0;
            int positiveNumbers = 0;

            foreach (int number in arrNumbers)
            {
                if (number < 0)
                {
                    negativeNumbers += 1;
                }
                else
                {
                    positiveNumbers += 1;
                }
            }
            return $"Number of positive numbers: {positiveNumbers}\n" +
                    $"Number of negative numbers: {negativeNumbers}";
        }
    }
}
