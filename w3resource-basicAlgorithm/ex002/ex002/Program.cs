using System;

namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Write a C# Sharp program to get the absolute difference between n and 51.
            //If n is greater than 51 return triple the absolute difference.

            //Sample Input:               Expected Output:
            //53                          6
            //30                          21
            //51                          0

            Console.WriteLine(absoluteDifference(53));
            Console.WriteLine(absoluteDifference(30));
            Console.WriteLine(absoluteDifference(51));
        }

        public static int absoluteDifference(int number)
        {
            return number > 51 ? Math.Abs(number - 51) * 3 : Math.Abs(number - 51);
        }
    }
}
