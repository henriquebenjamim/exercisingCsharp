using System;

namespace ex070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //70.Write a C# Sharp program to remove the first and last elements from a given string. Go to the editor
            //Sample Output:
            //Original string: PHP
            //After removing first and last elements: H
            //Original string: Python
            //After removing first and last elements: ytho
            //Original string: JavaScript
            //After removing first and last elements: avaScrip

            Console.WriteLine("Give me a string: ");
            string name = Console.ReadLine();
            Console.WriteLine(removingFirstLast(name));
            Console.WriteLine(removingFirstLast("Python"));
            Console.WriteLine(removingFirstLast("JavaScript"));
        }

        public static string removingFirstLast(string str)
        {
            string nameRemoved = str.Substring(1, str.Length - 2);
            return str.Length > 2 ? nameRemoved : str;
        }
    }
}
