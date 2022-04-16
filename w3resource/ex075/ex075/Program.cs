using System;

namespace ex075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //75.Write a C# Sharp program which takes a positive number and return the nth odd number.
            //Sample Output:
            //1st odd number: 1
            //2nd odd number: 3
            //4th odd number: 7
            //100th odd number: 199

            Console.Write("Give me a number: ");
            int number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine($"{number}th odd number: {number*2 - 1}");
            }
            else
            {
                if (number == 1)
                {
                    Console.WriteLine($"{number}th odd number: {number}");
                }
                else
                {
                    Console.WriteLine($"{number}th odd number: {number + 2}");
                }
            }
        }
    }
}
