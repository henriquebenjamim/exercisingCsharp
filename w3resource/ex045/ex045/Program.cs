using System;
using System.Linq;

namespace ex045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //45.Write a C# program to count a specified number in a given array of integers.
            //Test Data:
            //Input an integer: 5
            //Sample Output
            //Number of 5 present in the said array: 2
            
            int[] numberArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 1, 1, 3, 4, 5, 6, 7, 2, 3, 6 };
            // 1: 4; 2: 3; 3: 3; 4: 2; 5: 2; 6:3; 7: 2; 8: 1; 9: 1; 10: 1.

            Console.Write("Input an integer: ");
            int specifiedNumber = int.Parse(Console.ReadLine());
            int count = numberArr.Where(x => x == specifiedNumber).Count();

            Console.WriteLine($"Number of {specifiedNumber} present in the said array: {count}");
        }
    }
}
