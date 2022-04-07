using System;

namespace ex027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //27.Write a C# program and compute the sum of the digits of an integer.
            //Sample Output:
            //Input a number(integer): 12
            //Sum of the digits of the said integer: 3

            Console.Write("Input a number(integer): ");
            string number = Console.ReadLine();
            number.ToCharArray();
            int counting = 0;
            foreach(char value in number)
            {
                int realNumber = value - '0';
                counting += realNumber;
                
            }
            Console.WriteLine(counting);

        }
    }
}
