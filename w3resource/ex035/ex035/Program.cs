using System;

namespace ex035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //35.Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
            //Sample Output:
            //Input a first number(< 100): 75
            //Input a second number(> 100): 250
            //True

            Console.Write("Input a first number(< 100): ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Input a second number(> 100): ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine((firstNumber < 100 && secondNumber > 200) || firstNumber > 200 && secondNumber < 100);
        }
    }
}
