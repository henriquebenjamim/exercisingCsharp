using System;

namespace ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16.Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the said range otherwise false. Go to the editor

            //Sample Input:
            //20, 84
            //14, 50
            //11, 45
            //25, 40
            //Expected Output:
            //True
            //True
            //True
            //False

            Console.WriteLine(rangeTwoNumbers(20, 84));
            Console.WriteLine(rangeTwoNumbers(14, 50));
            Console.WriteLine(rangeTwoNumbers(11, 45));
            Console.WriteLine(rangeTwoNumbers(25, 40));
        }
        

        public static bool rangeTwoNumbers(int numberOne, int numberTwo)
        {
            return (numberOne <= 20 || numberOne >= 50) || (numberTwo <= 20 || numberTwo >= 50) ? true : false;
        }
    }
}
