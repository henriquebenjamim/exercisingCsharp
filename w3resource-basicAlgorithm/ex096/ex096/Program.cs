using System;

namespace ex096
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //96.Write a C# Sharp program to create a new array taking  the first and last elements of a given array of integers and length 1 or more.

            //Sample Input:
            //{ 10, 20, -30, -40, 30 }
            //Expected Output :
            //New array: 10 30

            Console.WriteLine(firstLastElementArr(new[] { 10, 20, -30, -40, 30}));
            Console.WriteLine(firstLastElementArr(new[] { 1}));
            
        }

        public static string firstLastElementArr(int[] numbersArr)
        {
            return numbersArr.Length >= 2 ? $"New array: {numbersArr[0]} {numbersArr[numbersArr.Length - 1]}" : 
                numbersArr.Length == 1 ? $"New array: {numbersArr[0]} {numbersArr[0]}" : "This array doesn't have any value.";
        }
    }
}
