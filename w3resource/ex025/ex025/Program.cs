using System;

namespace ex025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            for(int i=1; i <= 100; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
