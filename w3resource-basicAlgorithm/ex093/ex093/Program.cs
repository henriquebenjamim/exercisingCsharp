using System;

namespace ex093
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //93.Write a C# Sharp program to reverse a given array of integers and length 5.

            //Sample Input:
            //{ 10, 20, -30, -40, 50 }
            //Expected Output:
            //Reverse array: 50 - 40 - 30 20 10

            int[] numberArr = { 10, 20, -30, -40, 50 };
            Console.WriteLine("Reverse array: ");
            
            for (int i = numberArr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numberArr[i]} ");
            }
        }

    }
}
