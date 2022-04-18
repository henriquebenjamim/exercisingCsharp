using System;

namespace ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13.Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100. Go to the editor

            //Sample Input:
            //120, -1
            //- 1, 120
            //2, 120
            //Expected Output:
            //True
            //True
            //False

            Console.WriteLine(checkingTemperatures(120, -1));
            Console.WriteLine(checkingTemperatures(-1, 120));
            Console.WriteLine(checkingTemperatures(2, 120));
        }

        public static bool checkingTemperatures(int temperatureOne, int temperatureTwo)
        {
            return (temperatureOne < 0 && temperatureTwo > 100) || (temperatureTwo < 0 && temperatureOne > 100) ? true : false;
        }
    }
}
