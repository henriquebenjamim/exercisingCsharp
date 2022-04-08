using System;

namespace ex030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //30.Write a C# program to convert a hexadecimal number to decimal number. 
            //Sample Output:
            //Hexadecimal number: 4B0
            //Convert to -
            //Decimal number: 1200

            Console.Write("Type hexadecimal value: ");
            string hexaDecimalValue = Console.ReadLine();

            int decimalValue = Convert.ToInt32(hexaDecimalValue, 16);
            Console.WriteLine(decimalValue);
        }
    }
}
