using System;

namespace ex065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //65.Write a C# Sharp program to multiply all of elements of a given array of numbers by the array length.


            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int lenArr = numbers.Length;
            int[] newArr = new int[numbers.Length];

            for(int i = 0; i <= lenArr - 1; i++)
            {   
                newArr[i] = numbers[i] * (int)lenArr;
            }
            foreach(int value in newArr)
            {
                Console.Write($"{value} ");
            }

        }

    }
}
