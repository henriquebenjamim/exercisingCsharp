using System;

namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor
            //Test Data:
            //Enter first number - 5
            //Enter second number - 6
            //Enter third number - 7

            //Expected Output:
            //Result of specified numbers 5, 6 and 7, (x + y).z is 77 and x.y + y.z is 72

            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int z = int.Parse(Console.ReadLine());

            Console.Write($"Result of specified numbers: {x}, {y} and {z}, ");
            Console.Write($"(x + y).z is {(x + y) * z} ");
            Console.WriteLine($"and x.y + y.z is {x * y + y * z}");
        }
    }
}
