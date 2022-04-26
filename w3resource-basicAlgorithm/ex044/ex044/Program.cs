using System;

namespace ex044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //44.Write a C# Sharp program to check if a given number is within 2 of a multiple of 10.

            //Sample Input:
            //3
            //7
            //8
            //21
            //Expected Output:
            //False
            //False
            //True
            //True

            Console.Write("Give me a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 10 <= 2 || number % 10 >= 8);
        }
    }
}
