using System;

namespace ex045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //45.Write a C# Sharp program to compute the sum of the two given integers. If one of the given integer value is in the range 10..20 inclusive return 18.

            //Sample Input:
            //3, 7
            //10, 11
            //10, 20
            //21, 220
            //Expected Output:
            //10
            //18
            //18
            //241

            Console.WriteLine(givenIntegers(3, 7));
            Console.WriteLine(givenIntegers(10, 11));
            Console.WriteLine(givenIntegers(10, 20));
            Console.WriteLine(givenIntegers(21, 220));
        }

        public static int givenIntegers(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            return (numberOne >= 10 && numberOne <= 20) || (numberTwo >= 10 && numberTwo <= 20) ? 18 : sum;
        }
    }
}
