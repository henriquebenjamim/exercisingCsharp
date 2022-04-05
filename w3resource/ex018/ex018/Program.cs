using System;

namespace ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //18.Write a C# program to check two given integers and return true if one is negative and one is positive. Go to the editor
            //Sample Output:
            //Input first integer:
            //            -5
            //Input second integer:
            //            25
            //Check if one is negative and one is positive:
            //True


            Console.WriteLine("Input first integer: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Check if one is negative and one is positive: ");
            if((firstNumber > 0 && secondNumber < 0) || (firstNumber < 0 && secondNumber > 0))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            

            // link suggestion: 
            // Console.WriteLine((firstNumber < 0 && secondNumber > 0) || (firstNumber > 0 && secondNumber < 0));
        }
    }
}
