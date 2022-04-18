using System;

namespace ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14.Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.

            //Sample Input:
            //100, 199
            //250, 300
            //105, 190
            //Expected Output:
            //True
            //False
            //True

            Console.WriteLine(checkRangeNumbers(100, 199));
            Console.WriteLine(checkRangeNumbers(250, 300));
            Console.WriteLine(checkRangeNumbers(105, 190));
        }

        public static bool checkRangeNumbers(int numberOne, int numberTwo)
        {
            return (numberOne >= 100 && numberTwo <= 200) || (numberTwo >= 100 && numberOne <= 200) ? true : false;
        }
    }
}
