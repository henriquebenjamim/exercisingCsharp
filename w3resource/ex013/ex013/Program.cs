using System;

namespace ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13.Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. Go to the editor
            //Test Data:
            //Enter a number: 5
            //Expected Output:
            //555
            //5 5
            //5 5
            //5 5
            //555

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 4; i++)
            {
                if (i == 0 || i == 4)
                {
                    Console.WriteLine($"{number}{number}{number}");
                }
                else
                {
                    Console.WriteLine($"{number} {number}");
                }

            }
        }
    }
}
