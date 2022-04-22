using System;

namespace ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //23.Write a C# Sharp program to check if two given non-negative integers have the same last digit. Go to the editor

            //Sample Input:
            //123, 456
            //12, 512
            //7, 87
            //12, 45
            //Expected Output:
            //False
            //True
            //True
            //False

            Console.WriteLine(checkNonNegativeInt(123, 456));
            Console.WriteLine(checkNonNegativeInt(12, 512));
            Console.WriteLine(checkNonNegativeInt(7, 87));
            Console.WriteLine(checkNonNegativeInt(12, 45));
        }

        public static bool checkNonNegativeInt(int numberOne, int numberTwo)
        {
            string firstNumber = numberOne.ToString();
            string secondNumber = numberTwo.ToString();
            return (firstNumber[firstNumber.Length - 1] == secondNumber[secondNumber.Length - 1]) ? true : false;
            
        }
    }
}
