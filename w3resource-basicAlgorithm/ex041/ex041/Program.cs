using System;

namespace ex041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //41.Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5. Go to the editor

            //Sample Input:
            //5, 4
            //4, 3
            //1, 4
            //Expected Output:
            //True
            //False
            //True

            Console.WriteLine(checkFive(5, 4));
            Console.WriteLine(checkFive(4, 3));
            Console.WriteLine(checkFive(1, 4));
        }

        public static bool checkFive(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            int subtraction = numberOne - numberTwo;
            return (sum == 5) || (subtraction == 5) || (numberOne == 5) || (numberTwo == 5) ? true : false;
        }
    }
}
