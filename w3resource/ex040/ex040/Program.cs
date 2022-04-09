using System;

namespace ex040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //40.Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
            //Test Data:
            //Input first integer: 15
            //Input second integer: 12
            //Sample Output
            //15

            Console.Write("Input first integer: ");
            int firstInteger = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: ");
            int secondInteger = int.Parse(Console.ReadLine());

            int tempFirst = firstInteger;
            int tempSec = secondInteger;
            tempFirst -= 20;
            tempSec -= 20;

            if(tempFirst != tempSec)
            {
                if (tempFirst > tempSec)
                {
                    Console.WriteLine(firstInteger);
                }
                else
                {
                    Console.WriteLine(secondInteger);
                }
            }
            else
            {
                Console.WriteLine("0");
            }


        }
    }
}
