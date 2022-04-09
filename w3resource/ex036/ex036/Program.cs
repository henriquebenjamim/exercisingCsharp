using System;

namespace ex036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //36.Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
            //Sample Output:
            //Input a first number: -5
            //Input a second number: 8
            //True

            Console.Write("Input a first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Input a second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine((firstNumber >= -10 && firstNumber <= 10) || secondNumber >= -10 && secondNumber <= 10);
        }
    }
}
