using System;

namespace ex031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //31.Write a C# program to multiply corresponding elements of two arrays of integers.
            //Sample Output:
            //Array1: [1, 3, -5, 4]
            //Array2: [1, 4, -5, -2]
            //Multiply corresponding elements of two arrays:
            //1 12 25 - 8

            Console.Write("Type 4 values of first array: ");
            string firstArrayString = Console.ReadLine();
            Console.Write("Type 4 values of second array: ");
            string secondArrayString = Console.ReadLine();

            string[] firstArr = firstArrayString.Split(' ');
            string[] secondArr = secondArrayString.Split(' ');
            
            int[] multiArr = new int[4];
            int numberOne, numberTwo;
            for(int i = 0; i < 4; i++)
            {
                numberOne = Int16.Parse(firstArr[i]);
                numberTwo = Int16.Parse(secondArr[i]);
                multiArr[i] = numberOne * numberTwo;
            }
            foreach(int number in multiArr)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
