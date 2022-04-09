using System;

namespace ex048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //48.Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.
            //Test Data:
            //Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
            //Sample Output
            //True

            int[] numberArr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(numberArr[0] == numberArr[numberArr.Length -1 ]);
        }
    }
}
