using System;

namespace ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive. Go to the editor

            //Sample Input:
            //"Python", 1
            //"Python", o
            //"Python", 4
            //Expected Output:
            //Pthon
            //ython
            //Pythn

            Console.Write("Give me a string: ");
            string name = Console.ReadLine();
            Console.Write("Give me a position: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= name.Length - 1; i++)
            {
                if (i != number)
                {
                    Console.Write(name[i]);
                }
            }

        }

    }
}
