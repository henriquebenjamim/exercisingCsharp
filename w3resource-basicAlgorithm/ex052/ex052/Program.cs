using System;

namespace ex052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //52.Write a C# Sharp program to find the larger from two given integers. However if the two integers have the same remainder when divided by 7,
            //then the return the smaller integer. If the two integers are the same, return 0.

            //Sample Input:
            //11, 21
            //11, 20
            //10, 10
            //Expected Output:
            //21
            //20
            //0

            Console.WriteLine(twoIntegers(11, 21));
            Console.WriteLine(twoIntegers(11, 20));
            Console.WriteLine(twoIntegers(10, 10));
        }

        public static int twoIntegers(int numberOne, int numberTwo)
        {
            if (numberOne == numberTwo)
            {
                return 0;
            }
            if (numberOne % 7 == numberTwo % 7)
            {
                return (numberOne < numberTwo) ? numberOne : numberTwo;
            }
            return (numberOne > numberTwo) ? numberOne : numberTwo;
        }
    }
}
