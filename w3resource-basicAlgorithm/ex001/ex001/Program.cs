using System;

namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.

            //Sample Input:
            //1, 2
            //3, 2
            //2, 2
            //Expected Output:
            //3
            //5
            //12

            Console.Write("Give me a string with two integers: ");
            string[] str = Console.ReadLine().Split(", ");
            int numberOne = int.Parse(str[0]);
            int numberTwo = int.Parse(str[1]);

            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
            

        }
    }
}
