using System;

namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9.Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30

            //Expected Output:
            //The average of 10 , 15 , 20 , 30 is: 18

            Console.Write("Enter the First number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the four number: ");
            int fourNumber = int.Parse(Console.ReadLine());

            int average = (firstNumber + secondNumber + thirdNumber + fourNumber) / 4;
            Console.WriteLine($"The average of {firstNumber} , {secondNumber} , {thirdNumber} , {fourNumber} is: {average}");


        }
    }
}
