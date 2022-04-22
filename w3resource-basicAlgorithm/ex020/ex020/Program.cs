using System;

namespace ex020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20.Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive. Go to the editor

            //Sample Input:
            //78, 95
            //25, 35
            //40, 50
            //55, 60
            //Expected Output:
            //False
            //False
            //True
            //True

            Console.WriteLine(checkingRanges(78, 95));
            Console.WriteLine(checkingRanges(25, 35));
            Console.WriteLine(checkingRanges(40, 50));
            Console.WriteLine(checkingRanges(55, 60));
        }

        public static bool checkingRanges(int numberOne, int numberTwo)
        {
            return ((numberOne >= 40 && numberOne <= 50) || (numberTwo >= 40 && numberTwo <= 50)) || ((numberOne >= 50 && numberOne <= 60) || (numberTwo >= 50 && numberTwo <= 60)) ? true : false;
        }
    }
}
