using System;

namespace ex042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //42.Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13.

            //Sample Input:
            //13
            //14
            //27
            //41
            //Expected Output:
            //True
            //True
            //True
            //False

            Console.WriteLine(multipleMoreThirtheen(13));
            Console.WriteLine(multipleMoreThirtheen(14));
            Console.WriteLine(multipleMoreThirtheen(27));
            Console.WriteLine(multipleMoreThirtheen(41));
        }

        public static bool multipleMoreThirtheen(int number)
        {
            return (number % 13 == 0) || (number % 13 == 1) ? true : false;
        }
    }
}
