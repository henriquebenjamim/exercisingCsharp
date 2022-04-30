using System;

namespace ex058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //58.Write a C# Sharp program to check two given integers and return the value whichever value is nearest to 13 without going over. Return 0 if both numbers go over.

            //Sample Input:
            //4, 5
            //7, 12
            //10, 13
            //17, 33
            //Expected Output:
            //5
            //12
            //13
            //0

            Console.WriteLine(nearestThirteen(4, 5));
            Console.WriteLine(nearestThirteen(7, 12));
            Console.WriteLine(nearestThirteen(10, 13));
            Console.WriteLine(nearestThirteen(17, 33));
        }

        public static int nearestThirteen(int numberOne, int numberTwo)
        {

            return numberOne > 13 || numberTwo > 13 ? 0 :
            numberTwo - 13 > numberOne - 13 ? numberTwo : numberOne;
        }

    }
}
