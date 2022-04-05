using System;

namespace ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19.Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
            Console.WriteLine("Give me first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(twoNumbers(numberOne, secondNumber));

        }

        public static int twoNumbers(int numberOne, int numberTwo)
        {   
            // if in one line is too pratical
            return numberOne == numberTwo ? (numberOne + numberTwo) * 3 : numberOne + numberTwo;
        }
    }
}
