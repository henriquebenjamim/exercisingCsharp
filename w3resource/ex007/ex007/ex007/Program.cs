using System;

namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
            //Test Data:
            //Input the first number: 25
            //Input the second number: 4
            //Expected Output:
            //25 + 4 = 29
            //25 - 4 = 21
            //25 x 4 = 100
            //25 / 4 = 6
            //25 mod 4 = 1

            Console.Write("Input the first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
            Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
            Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
            Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo}");
            Console.WriteLine($"{numberOne} % {numberTwo} = {numberOne % numberTwo}");

        }
    }
}
