using System;

namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.

            //Sample Input:
            //103
            //90
            //89

            //Expected Output:
            //True
            //True
            //False

            Console.WriteLine(checkIs(103));
            Console.WriteLine(checkIs(90));
            Console.WriteLine(checkIs(89));
            
        }

        public static bool checkIs(int number)
        {

            return Math.Abs((number - 100)) <= 10 || Math.Abs((number - 200)) <= 10 ? true : false;
        }
    }
}
