using System;

namespace ex048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //48.Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.

            //Sample Input:
            //1, 2, 3
            //4, 5, 6
            //- 1, 1, 0
            //Expected Output:
            //True
            //True
            //False

            Console.WriteLine(greaterThen(1, 2, 3));
            Console.WriteLine(greaterThen(4, 5, 6));
            Console.WriteLine(greaterThen(-1, 1, 0));
        }

        public static bool greaterThen(int x, int y, int z)
        {
            return z > y && y > x;
        }
    }
}
