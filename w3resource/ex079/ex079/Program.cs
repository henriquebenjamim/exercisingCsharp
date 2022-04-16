using System;

namespace ex079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //79.Write a C# Sharp program to convert an integer to string and a string to an integer.
            //Sample Output:
            //Original value and type: 50, System.String
            //Convert string to integer:
            //Return value and type: 50, System.Int32
            //Original value and type: 122, System.Int32
            //Convert integer to string:
            //Return value and type: 122, System.String

            Console.Write("Give me a value: ");
            string str = Console.ReadLine();
            Console.WriteLine($"Original value and type: {str}, {str.GetType()}");
            Console.WriteLine("Convert string to integer: ");
            Console.WriteLine($"Return value and type: {strToInt(str)}, {strToInt(str).GetType()}");

            Console.WriteLine();
            Console.Write("Give me another value: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Original value and type: {number}, {number.GetType()}");
            Console.WriteLine("Convert string to integer: ");
            Console.WriteLine($"Return value and type: {intToStr(number)}, {intToStr(number).GetType()}");
        }

        public static int strToInt(string str)
        {
            return int.Parse(str);
        }

        public static string intToStr(int number)
        {
            return number.ToString();
        }
    }
}
