using System;
using System.Linq;

namespace ex039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //39.Write a C# program to find the largest and lowest values from three integer values.
            //Test Data:
            //Input first integer: 15         
            //Input second integer: 25          
            //Input third integer: 30
            //Sample Output
            //Largest of three: 30
            //Lowest of three: 15

            Console.Write("Input first integer: ");
            int firstInteger = int.Parse(Console.ReadLine());
            Console.Write("Input first integer: ");
            int secondInteger = int.Parse(Console.ReadLine());
            Console.Write("Input first integer: ");
            int thirdInteger = int.Parse(Console.ReadLine());

            int[] numberArr = { firstInteger, secondInteger, thirdInteger };
            
            Console.WriteLine($"Largest of three: {numberArr.Max()}");
            Console.WriteLine($"Lowest of three: {numberArr.Min()}");
        }
    }
}
