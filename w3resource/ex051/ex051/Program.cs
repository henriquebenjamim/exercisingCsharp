using System;


namespace ex051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //51.Write a C# program to get the larger value between first and last element of an array (length 3) of integers.
            //Test Data:
            //Array1: [1, 2, 5, 7, 8]
            //Highest value between first and last values of the said array: 8

            // i will not use linq

            int[] arr1 = { 1, 2, 5, 7, 8 };
            int[] arr2 = { 2, 7, 12, 33, 45 };
            int[] arr3 = { 102, 2 };
            int[] arr4 = { 9, 9, 23, 1, 9 };
            Console.WriteLine(maximmumValue(arr1));
            Console.WriteLine(maximmumValue(arr2));
            Console.WriteLine(maximmumValue(arr3));
            Console.WriteLine(maximmumValue(arr4));

            //Array1: [1, 2, 5, 7, 8]
            //Array2: [2, 7, 12, 33, 45]
            //Array3: [102, 2]
            //Array4: [9, 9, 23, 1, 9]
        }

        public static string maximmumValue(int[] arr)
        {
            int mostValue = 0;
            if(arr.Length > 3)
            {
                foreach(int value in arr)
                {
                    if(value > mostValue)
                    {
                        mostValue = value;
                    }
                }
                return "Highest value between first and last values of the said array: " + mostValue;
            }
            else
            {
                return "I can't do that, lenght < 3.";
            }
        }
    }
}
