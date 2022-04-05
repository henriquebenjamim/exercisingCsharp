using System;

namespace ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12.Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in
            //the next row, with no separation.You should do it two times: Use Console. Write and then use { 0}. Go to the editor
            //Test Data:
            //Enter a digit: 25
            //Expected Output:
            //25 25 25 25
            //25252525
            //25 25 25 25
            //25252525

            Console.Write("Enter a digit: ");
            int number = int.Parse(Console.ReadLine());
            for(int i=1; i <= 4; i++)
            {   
                if(i % 2 == 0)
                {
                    Console.WriteLine($"{number}{number}{number}{number}");
                }
                else
                {
                    Console.WriteLine($"{number} {number} {number} {number}");
                }
            }
        }
    }

}
