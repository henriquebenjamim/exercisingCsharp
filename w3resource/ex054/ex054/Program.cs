using System;

namespace ex054
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //54.Write a C# program to get the century from a year.
            Console.WriteLine(century(1900));
            Console.WriteLine(century(1560));

        }

        public static int century(int year)
        {
            return year / 100 + ((year % 100 == 0) ? 0 : 1);
        }
    }
}
