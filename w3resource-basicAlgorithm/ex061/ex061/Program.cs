using System;

namespace ex061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //61.Write a C# Sharp program to insert a given string into middle of the another given string of length 4.

            //Sample Input:
            //"[[]]","Hello"
            //"(())", "Hi"
            //Expected Output:
            //[[Hello]]
            //((Hi))

            Console.WriteLine(addInTheMiddle("[[]]", "Hello"));
            Console.WriteLine(addInTheMiddle("(())", "Hi"));
        }

        public static string addInTheMiddle(string str1, string str2)
        {
            return $"{str1.Substring(0, 2)}{str2}{str1.Substring(2)}";
        }
    }
}
