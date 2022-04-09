using System;

namespace ex049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //49.Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.
            //Test Data:
            //Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
            //Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
            //Check if the first element or the last element of the two arrays(leng th 1 or more) are equal.
            //Sample Output
            //True

            int[] arr1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] arr2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine(comparingArr(arr1, arr2));

        }

        public static Boolean comparingArr(int[] arr1, int[] arr2)
        {
            if(arr1.Length > 1 && arr2.Length > 1)
            {
                if((arr1[0] == arr2[0]) || (arr1[arr1.Length -1] == arr2[arr2.Length -1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
