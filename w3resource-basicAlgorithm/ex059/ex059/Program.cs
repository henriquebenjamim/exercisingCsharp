using System;

namespace ex059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //59.Write a C# Sharp program to check three given integers (small, medium and large) and return true if the difference between small and medium and the difference
            //between medium and large is same.

            //Sample Input:
            //4, 5, 6
            //7, 12, 13
            //- 1, 0, 1
            //Expected Output:
            //True
            //False
            //True

            Console.WriteLine(sameDifference(4, 5, 6));
            Console.WriteLine(sameDifference(7, 12, 13));
            Console.WriteLine(sameDifference(-1, 0, 1));
        }

        public static bool sameDifference(int numberOne, int numberTwo, int numberThree)
        {
            return numberThree - numberTwo == numberTwo - numberOne ? true : false;
        }
    }
}
