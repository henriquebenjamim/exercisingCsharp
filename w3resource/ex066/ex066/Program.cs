using System;

namespace ex066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to find the minimum value from two given two numbers, represented as string.

            Console.Write("Write a number: ");
            string number = Console.ReadLine();
            if(number.Length > 2)
            {
                Console.WriteLine("Not found. 2 numbers needed.");
            }
            else
            {
                if (number.Length == 2)
                {
                    char[] converting = number.ToCharArray();
                    if((int)converting[0] > (int)converting[1])
                    {
                        Console.WriteLine(converting[1]);
                    }
                    else if((int)converting[0] < (int)converting[1])
                    {
                        Console.WriteLine(converting[0]);
                    }

                }
            }

            
            Console.WriteLine(minimumValue("40", "35"));
        }

        public static int minimumValue(string numberOne, string numberTwo)
        {
            return Int32.Parse(numberOne) > Int32.Parse(numberTwo) ? Int32.Parse(numberTwo) : Int32.Parse(numberOne);
        }
    }
}
