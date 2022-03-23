using System;

namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"element - {i}: ");
                inputNumber = int.Parse(Console.ReadLine());
                numbers[i] = inputNumber;
            }

            Console.Write("Elements in array are: ");

            foreach (int value in numbers)
            {
                Console.Write(value + " ");
            }



            //1.write a program in c# sharp to store elements in an array and print it. go to the editor
            //test data:
            //input 10 elements in the array:
            //element - 0 : 1
            //element - 1 : 1
            //element - 2 : 2.......
            //expected output :
            //elements in array are: 1 1 2 3 4 5 6 7 8 9
        }
    }
}
