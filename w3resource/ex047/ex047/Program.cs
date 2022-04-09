using System;

namespace ex047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //47.Write a C# program to compute the sum of all the elements of an array of integers.
            //Test Data:
            //Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
            //Sample Output
            //Sum: 69

            Console.Write("Lets creat an array, how many numbers: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbersArr = new int[n];
            int countingValues = 0;


            for(int i = 0; i < n; i++)
            {
                Console.Write($"Type the {i+1} number: ");
                int tempValue = int.Parse(Console.ReadLine());
                
                numbersArr[0] = tempValue;
                countingValues += tempValue;
            }

            Console.WriteLine($"Sum {countingValues}");
        }

    }
}
