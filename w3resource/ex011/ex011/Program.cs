using System;

namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". Go to the editor
            //Test Data:
            //Enter your age - 25
            //Expected Output:
            //You look older than 25

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"You look older than {age}");
        }
    }
}
