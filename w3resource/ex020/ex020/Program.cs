using System;

namespace ex020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to get the absolute value of the difference between two given numbers.
            //Return double the absolute value of the difference if the first number is greater than second number.
            Console.WriteLine(absoluteValue(13, 40));
            Console.WriteLine(absoluteValue(50, 21));

        }

        public static int absoluteValue(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber ? (firstNumber - secondNumber) * 2: (firstNumber - secondNumber) + ((secondNumber - firstNumber) * 2);
        }
    }
}
