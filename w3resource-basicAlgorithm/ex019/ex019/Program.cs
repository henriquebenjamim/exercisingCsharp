using System;

namespace ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19.Write a C# Sharp program to check which number nearest to the value 100 among two given integers. Return 0 if the two numbers are equal. Go to the editor

            //Sample Input:
            //78, 95
            //95, 95
            //99, 70
            //Expected Output:
            //95
            //0
            //99

            Console.WriteLine(nearestNumber(78, 95));
            Console.WriteLine(nearestNumber(95, 95));
            Console.WriteLine(nearestNumber(99, 70));
        }

        public static int nearestNumber(int numberOne, int numberTwo)
        {
            int spreadOne = 100 - numberOne;
            int spreadTwo = 100 - numberTwo;
            return spreadOne != spreadTwo ? spreadOne > spreadTwo ? numberTwo : numberOne : 0 ;
        }
    }
}
