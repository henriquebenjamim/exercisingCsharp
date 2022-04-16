using System;

namespace ex087
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //87.Write a C# Sharp program to reverse a boolean value.
            //Sample Output:
            //Original value: False
            //Reverse value: True
            //Original value: True
            //Reverse value: False
            bool status = true;
            bool status2 = false;
            bool status3 = !false;
            Console.WriteLine(reversing(status));
            Console.WriteLine(reversing(status2));
            Console.WriteLine(reversing(status3));
        }


        public static bool reversing(bool status)
        {
            return !status;
        }
    }
}
