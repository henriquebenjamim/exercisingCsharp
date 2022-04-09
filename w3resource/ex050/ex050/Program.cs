using System;

namespace ex050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //50.Write a C# program to rotate an array (length 3) of integers in left direction.
            //Test Data:
            //Array1: [1, 2, 8]
            //After rotating array becomes: [2, 8, 1]

            Console.WriteLine("How many numbers in array? ");
            int numbers = int.Parse(Console.ReadLine());
            int tempNumber = 0;
            int[] arr = new int[numbers];
            int[] reverseArr = new int[numbers];


            for(int i = 0; i < numbers; i++)
            {
                Console.Write($"Type {i+1}º number: ");
                int numberValue = int.Parse(Console.ReadLine());
                tempNumber = numberValue;
                arr[i] = tempNumber;
            }
            
            for(int j = 0; j < numbers; j++)
            {
                tempNumber = arr[arr.Length - 1 - j];
                reverseArr[j] = tempNumber;
            }

            Console.Write("[");
            foreach(int value in reverseArr)
            {
                if(reverseArr[reverseArr.Length - 1] == value)
                {
                    Console.WriteLine($"{value}]");
                    break;
                }
                Console.Write($"{value}, ");
            }
        }
    }
}
