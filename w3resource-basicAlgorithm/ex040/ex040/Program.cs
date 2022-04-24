using System;

namespace ex040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //40.Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30. Go to the editor

            //Sample Input:
            //12, 17
            //2, 17
            //22, 17
            //20, 0
            //Expected Output:
            //29
            //30
            //39
            //30

            Console.WriteLine(sumRangeTenTwenty(12, 17));
            Console.WriteLine(sumRangeTenTwenty(2, 17));
            Console.WriteLine(sumRangeTenTwenty(22, 17));
            Console.WriteLine(sumRangeTenTwenty(20, 0));
        }

        public static int sumRangeTenTwenty(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            return sum >= 10 && sum <= 20 ? 30 : sum;
        }
    }
}
