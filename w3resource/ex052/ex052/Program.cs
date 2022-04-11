using System;

namespace ex052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //52.Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers. Go to the editor
            //Test Data:
            //Array1: [1, 2, 5]
            //Array2: [0, 3, 8]
            //Array3: [-1, 0, 2]
            //New array: [2, 3, 0]

            int[] arr1 = { 1, 2, 5 };
            int[] arr2 = { 0, 3, 8 };
            int[] arr3 = { -1, 0, 2 };
            int[][] arrMaster = { arr1, arr2, arr3 };
            int[] arrModified = new int[3];
            Console.Write("New array: [");
            for(int i = 0; i < 3; i++)
            {
                arrModified[i] = arrMaster[i][1];
                if(i <= 1)
                {
                    Console.Write($"{arrModified[i]}, ");
                }
                else
                {
                    Console.Write($"{arrModified[i]}]");
                }
            }
            
            Console.WriteLine();
        }
    }
}
