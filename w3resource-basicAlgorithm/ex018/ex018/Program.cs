using System;
using System.Linq;

namespace ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //18.Write a C# Sharp program to check the largest number among three given integers. Go to the editor

            //Sample Input:
            //1,2,3
            //1,3,2
            //1,1,1
            //1,2,2
            //Expected Output:
            //3
            //3
            //1
            //2

            Console.WriteLine(largestNumber(1, 2, 3));
            Console.WriteLine(largestNumber(1, 3, 2));
            Console.WriteLine(largestNumber(1, 1, 1));
            Console.WriteLine(largestNumber(1, 2, 2));
        }

        public static int largestNumber(int numberOne, int numberTwo, int numberThree)
        {
            int firstMax = Math.Max(numberOne, numberTwo);
            int maxMaximum = Math.Max(firstMax, numberThree);
            return maxMaximum;
        }
    }
}
