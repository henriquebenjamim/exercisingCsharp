using System;

namespace ex079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //79.Write a C# Sharp program to create a new string from a given string after swapping last two characters.

            //Sample Input:
            //"Hello"
            //"Python"
            //"PHP"
            //"JS"
            //"C"
            //Expected Output:
            //Helol
            //Pythno
            //PPH
            //SJ
            //C

            Console.WriteLine(swapTwoLast("Hello"));
            Console.WriteLine(swapTwoLast("Python"));
            Console.WriteLine(swapTwoLast("PHP"));
            Console.WriteLine(swapTwoLast("JS"));
            Console.WriteLine(swapTwoLast("C"));
        }

        public static string swapTwoLast(string str)
        {
            int lastInd = str.Length - 1;
            int beforeLastInd = str.Length - 2;
            return str.Length > 2 ? $"{str.Substring(0, lastInd -1 )}{str.Substring(lastInd)}{str.Substring(beforeLastInd, 1)}":
                str.Length == 2 ? str.Substring(lastInd) + str.Substring(beforeLastInd, 1) : str;
        }
    }
}
