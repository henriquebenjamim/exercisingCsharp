using System;

namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int element;

            Console.Write("Input the number of elements to store in the array: ");
            int howManyNumbers = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[howManyNumbers];

            Console.WriteLine($"Input {howManyNumbers} number of elements in the array");
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write($"element - {i}: ");
                element = int.Parse(Console.ReadLine());
                numbersArray[i] = element;
            }

            Console.Write("The values store into the array are: ");
            foreach(int value in numbersArray)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
            Console.Write("The values store into the array in reverse are: ");
            for (int j = numbersArray.Length - 1; j >= 0; j--)
            {
                Console.Write(numbersArray[j] + " ");
            }

            //Write a program in C# Sharp to read n number of values in an array and display it in reverse order. Go to the editor
            //Test Data:
            //Input the number of elements to store in the array :3
            //Input 3 number of elements in the array :
            //element - 0 : 2
            //element - 1 : 5
            //element - 2 : 7
            //Expected Output:
            //The values store into the array are:
            //2 5 7
            //The values store into the array in reverse are :
            //7 5 2
        }
    }
}
