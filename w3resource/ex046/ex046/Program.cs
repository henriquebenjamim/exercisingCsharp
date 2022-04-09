using System;

namespace ex046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //46.Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.
            //Test Data:
            //Input an integer: 25
            //Sample Output
            //False

            int[] numbersArr = { 25, 1, 2, 3, 4, 5, 6, 7, 30 };
            Console.Write("Input an integer: ");
            int number = int.Parse(Console.ReadLine());
            
            Console.WriteLine(numbersArr[0] == number || numbersArr[numbersArr.Length - 1] == number);
        }
    }
}
