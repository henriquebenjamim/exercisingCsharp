using System;

namespace ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8. Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor
            //Test Data:
            //Enter the number: 5
            //Expected Output:
            //5 * 0 = 0
            //5 * 1 = 5
            //5 * 2 = 10
            //5 * 3 = 15
            //...
            //5 * 10 = 50

            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
