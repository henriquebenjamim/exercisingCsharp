using System;

namespace ex050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //50.Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit. Go to the editor

            //Sample Input:
            //11, 21, 31
            //11, 22, 31
            //11, 22, 33
            //Expected Output:
            //True
            //True
            //False

            Console.WriteLine(checkRightDigit(11, 21, 31));
            Console.WriteLine(checkRightDigit(11, 22, 31));
            Console.WriteLine(checkRightDigit(11, 22, 33));
            Console.WriteLine(checkRightDigit(44, 12, 43));
            Console.WriteLine(checkRightDigit(15, 25, 35));
        }

        public static bool checkRightDigit(int numberOne, int numberTwo, int numberThree)
        {
            return numberOne % 10 == numberTwo % 10 || numberOne % 10 == numberThree % 10 || numberTwo % 10 == numberThree % 10;
        }
    }
}
