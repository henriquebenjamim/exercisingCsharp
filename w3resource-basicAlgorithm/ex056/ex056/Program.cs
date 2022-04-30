using System;

namespace ex056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //56.Write a C# Sharp program to compute the sum of the three integers. If one of the values is 13 then do not count it and its right towards the sum.

            //Sample Input:
            //4, 5, 7
            //7, 4, 12
            //10, 13, 12
            //13, 12, 18
            //Expected Output:
            //16
            //23
            //10
            //0

            Console.WriteLine(sumOrThirtheen(4, 5, 7));
            Console.WriteLine(sumOrThirtheen(7, 4, 12));
            Console.WriteLine(sumOrThirtheen(10, 13, 12));
            Console.WriteLine(sumOrThirtheen(13, 12, 18));
        }

        public static int sumOrThirtheen(int numberOne, int numberTwo, int numberThree)
        {
            int sum = 0;
            if (numberOne == 13 || numberTwo == 13 || numberThree == 13)
            {
                if (numberOne == 13)
                {
                    sum = 0;
                }
                else
                {
                    if (numberTwo == 13)
                    {
                        sum += numberOne;
                    }
                    else
                    {
                        sum += numberOne + numberTwo;
                    }
                }
            }
            else
            {
                sum = numberOne + numberTwo + numberThree;
            }
            return sum;
        }
    }
}
