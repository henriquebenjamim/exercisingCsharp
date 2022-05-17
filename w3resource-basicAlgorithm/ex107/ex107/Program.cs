using System;

namespace ex107
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //107.Write a C# Sharp program to find the largest value from first, last, and middle elements of a given array of integers of odd length
            //(at least 1).

            //Sample Input:
            //{ 1}
            //{ 1,2,9}
            //{ 1,2,9,3,3}
            //{ 1,2,3,4,5,6,7}
            //{ 1,2,2,3,7,8,9,10,6,5,4}
            //Expected Output :
            //1
            //9
            //9
            //7
            //8

            Console.WriteLine(test(new[] { 1 }));
            Console.WriteLine(test(new[] { 1, 2, 9 }));
            Console.WriteLine(test(new[] { 1, 2, 9, 3, 3 }));
            Console.WriteLine(test(new[] { 1, 2, 3, 4, 5, 6, 7 }));
            Console.WriteLine(test(new[] { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 }));

        }

        public static int test(int[] numbers)
        {
            int first, middle_ele, last_ele, max_ele;

            first = numbers[0];
            middle_ele = numbers[numbers.Length / 2];
            last_ele = numbers[numbers.Length - 1];
            max_ele = first;

            if (middle_ele > max_ele)
            {
                max_ele = middle_ele;
            }

            if (last_ele > max_ele)
            {
                max_ele = last_ele;
            }

            return max_ele;
        }
    }
}
