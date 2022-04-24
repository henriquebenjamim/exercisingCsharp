using System;
using System.Linq;

namespace ex033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //33.Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element. Go to the editor

            //Sample Input:
            //{ 1,2,9,3}, 3
            //{ 1,2,3,4,5,6}, 2
            //{ 1,2,2,3}, 9
            //Expected Output:
            //True
            //True
            //False

            int[] firstArr = { 1, 2, 9, 3 };
            int[] secondArr = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(checkEquals(firstArr, 3));
            Console.WriteLine(checkEquals(secondArr, 2));
            Console.WriteLine(checkEquals(new[] {1, 2, 2, 3}, 9));
        }

        public static bool checkEquals(int[] numberArr, int number)
        {
            return numberArr.Any(x => x == number) ? true : false;
        }
    }
}
