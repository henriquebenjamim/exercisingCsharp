using System;

namespace ex057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //57.Write a C# Sharp program to compute the sum of the three given integers. However, if any of the values is in the range 10..20 inclusive then that value counts as 0, except 13 and 17.

            //Sample Input:
            //4, 5, 7
            //7, 4, 12
            //10, 13, 12
            //17, 12, 18
            //Expected Output:
            //16
            //11
            //13
            //17

            Console.WriteLine(tripleSumRangeConditions(4, 5, 7));
            Console.WriteLine(tripleSumRangeConditions(7, 4, 12));
            Console.WriteLine(tripleSumRangeConditions(10, 13, 12));
            Console.WriteLine(tripleSumRangeConditions(17, 12, 18));
        }

        public static int tripleSumRangeConditions(int numberOne, int numberTwo, int numberThree)
        {
            bool firstCondition = numberOne >= 10 && numberOne <= 20 && numberOne != 13 && numberOne != 17;
            bool secondCondition = numberTwo >= 10 && numberTwo <= 20 && numberTwo != 13 && numberTwo != 17;
            bool thirthCondition = numberThree >= 10 && numberThree <= 20 && numberThree != 13 && numberThree != 17;

            int sum = 0;

            if (!firstCondition && !secondCondition && !thirthCondition)
            {
                sum = numberOne + numberTwo + numberThree;
            }
            else
            {
                if (!firstCondition)
                {
                    sum += numberOne;
                }
                if(!secondCondition)
                {
                    sum += numberTwo;
                }
                if(!thirthCondition)
                {
                    sum += numberThree;
                }
            }

            return sum;
        }
    }
}
