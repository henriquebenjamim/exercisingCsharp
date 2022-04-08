using System;

namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Write a C# Sharp program to check two given integers,
            //and return true if one of them is 30 or if their sum is 30.

            //Sample Input:           expected output:
            //30, 0                   True
            //25, 5                   True
            //20, 30                  True
            //20, 25                  False

            Console.WriteLine(checkNumbers(30, 0));
            Console.WriteLine(checkNumbers(25, 5));
            Console.WriteLine(checkNumbers(20, 30));
            Console.WriteLine(checkNumbers(20, 25));
        }

        public static bool checkNumbers(int numberOne, int numberTwo)
        {
            if(numberOne == 30 || numberTwo == 30 || numberOne + numberTwo == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
