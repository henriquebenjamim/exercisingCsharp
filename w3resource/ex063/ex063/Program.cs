using System;
using System.Linq;
using System.Collections;

namespace ex063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //63.Write a C# program to check if a given number present in an array of numbers

            int[] numbersOne = { 1, 2, 3, 5, 6, 9, 10 };
            int[] numberTwo = { 2, 4, 6, 8, 10 };
            int[] numberThree = { 1, 3, 5, 7, 9 };

            Console.Write("What number? ");
            int number = int.Parse(Console.ReadLine());

            foreach(int value in numbersOne)
            {
                if(value == number)
                {
                    Console.WriteLine("It's here.");
                }
            }
            Console.WriteLine(checkNumber(numberTwo, number));
        }

        public static string checkNumber(int[] arr, int number)
        {
            int indexOfNumbers = Array.IndexOf(arr, number);
            if(indexOfNumbers > -1)
            {
                return $"{number} is PRESENT on {indexOfNumbers} index.";
            }
            else
            {
                return $"{number} isn't PRESENT";
            }
        }
    }
}
