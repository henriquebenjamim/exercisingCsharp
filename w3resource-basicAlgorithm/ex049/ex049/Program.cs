using System;

namespace ex049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //49.Write a C# Sharp program to check if three given numbers are in strict increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8.
            //However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7. 

            //Sample Input:
            //1, 2, 3, false
            //1, 2, 3, true
            //10, 2, 30, false
            //10, 10, 30, true
            //Expected Output:
            //True
            //True
            //False
            //True

            Console.WriteLine(strictIncreasingOrder(1, 2, 3, false));
            Console.WriteLine(strictIncreasingOrder(1, 2, 3, true));
            Console.WriteLine(strictIncreasingOrder(10, 2, 30, false));
            Console.WriteLine(strictIncreasingOrder(10, 10, 30, true));
        }

        public static bool strictIncreasingOrder(int numberOne, int numberTwo, int numberThree, bool equalsConditions)
        {
            if (equalsConditions == true)
            {
                if(numberOne <= numberTwo && numberTwo <= numberThree)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (numberOne < numberTwo && numberTwo < numberThree)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
