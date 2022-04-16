using System;
using System.Text;

namespace ex076
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //76.Write a C# Sharp program to get the ASCII value of a given character. Go to the editor
            //Sample Output:
            //Ascii value of 1 is: 49
            //Ascii value of A is: 65
            //Ascii value of a is: 97
            //Ascii value of # is: 35

            Console.Write("Give me a value: ");
            string str = Console.ReadLine();

            byte[] asciiBytes = Encoding.ASCII.GetBytes(str);
            foreach(byte value in asciiBytes)
            {
                Console.WriteLine($"Ascii value of {str} is: {value}");
            }
        }
    }
}
