using System;

namespace ex047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //47.Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers. Go to the editor

            //Sample Input:
            //1, 2, 3
            //4, 5, 6
            //- 1, 1, 0
            //Expected Output:
            //True
            //False
            //True

            Console.WriteLine(checkSums(1, 2, 3));
            Console.WriteLine(checkSums(4, 5, 6));
            Console.WriteLine(checkSums(-1, 1, 0));
        }

        public static bool checkSums(int x, int y, int z)
        {
            return x == y + z || y == x + z || z == y + x ? true : false;
        }
    }
}
