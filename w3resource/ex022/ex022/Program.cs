using System;

namespace ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //22.Write a C# program to check if an given integer is within 20 of 100 or 200. Go to the editor
            //Sample Output:
            //Input an integer: 25
            //False

            Console.Write("Input an integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(resulting(number));
        }

        public static bool resulting(int number)
        {
            if (Math.Abs(number - 100) <= 20 || Math.Abs(number - 200) <= 20)
                return true;
            return false;
        }
    }
}
