using System;
using System.Linq;

namespace ex101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //101.Write a C# Sharp program to check a given array of integers, length 3 and create a new array.
            //If there is a 5 in the given array immediately followed by a 7 then set 7 to 1.

            //Sample Input:
            //{ 1, 5, 7 }
            //Expected Output :
            //Original array:  1, 5, 7
            //New array: 1 5 1

            int[] arr = fiftySeven(new[] { 1, 5, 3 });
            Console.WriteLine("New array: ");
            foreach (int value in arr)
            {
                Console.Write($"{value} ");
            }

        }

        public static int[] fiftySeven(int[] numbersArr)
        {
            for (int i = 0; i < numbersArr.Length - 1; i++)
            {
                if (numbersArr[i].Equals(5) && numbersArr[i + 1].Equals(7))
                {
                    numbersArr[i + 1] = 1;
                }
            }
            return numbersArr;
        }
    }
}
