using System;

namespace ex033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //33.Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
            //Sample Output:
            //Input first integer: 15       
            //True

            Console.Write("Input first integer: ");
            int number = int.Parse(Console.ReadLine());

            if(number > 0)
            {
                Console.WriteLine((number % 3 == 0 || number % 7 == 0));
            }
            
        }
    }
}
