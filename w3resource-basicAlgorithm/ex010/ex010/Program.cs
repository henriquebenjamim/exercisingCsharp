using System;

namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7. Go to the editor

            //Sample Input:
            //3
            //14
            //12
            //37
            //Expected Output:
            //True
            //True
            //True
            //False

            Console.WriteLine(checkDivisors(3));
            Console.WriteLine(checkDivisors(14));
            Console.WriteLine(checkDivisors(12));
            Console.WriteLine(checkDivisors(37));

        }

        public static bool checkDivisors(int number)
        {
            return number % 3 == 0 || number % 7 == 0 ? true : false;
        }
    }
}
