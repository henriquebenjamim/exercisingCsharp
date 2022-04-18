using System;

namespace ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15.Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false. Go to the editor

            //Sample Input:
            //11, 20, 12
            //30, 30, 17
            //25, 35, 50
            //15, 12, 8
            //Expected Output:
            //True
            //True
            //True
            //False

            Console.WriteLine(rangeNumbers(11, 20, 12));
            Console.WriteLine(rangeNumbers(30, 30, 17));
            Console.WriteLine(rangeNumbers(25, 35, 50));
            Console.WriteLine(rangeNumbers(15, 12, 8));

        }

        public static bool rangeNumbers(int numberOne, int numberTwo, int numberThree)
        {
            return (numberOne >= 20 && numberOne <= 50) || (numberTwo >= 20 && numberTwo <= 50) || (numberThree >= 20 && numberThree <= 50) ? true : false;
        }
    }
}
