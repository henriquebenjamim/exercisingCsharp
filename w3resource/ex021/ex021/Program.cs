using System;

namespace ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //21.Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            Console.Write("First number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber == 20 || secondNumber == 20 || (firstNumber + secondNumber == 20));
        }
    }
}
