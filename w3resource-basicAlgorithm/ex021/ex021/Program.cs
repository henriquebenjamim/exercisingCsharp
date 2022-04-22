using System;

namespace ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //21.Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range. Go to the editor

            //Sample Input:
            //78, 95
            //20, 30
            //21, 25
            //28, 28
            //Expected Output:
            //0
            //30
            //25
            //28

            Console.WriteLine(checkRangeNumbers(78, 95));
            Console.WriteLine(checkRangeNumbers(20, 30));
            Console.WriteLine(checkRangeNumbers(21, 25));
            Console.WriteLine(checkRangeNumbers(28, 28));
        }

        public static int checkRangeNumbers(int numberOne, int numberTwo)
        {
            int answer = 0;

            if(numberOne < 20 && numberOne > 30 && numberTwo < 20 && numberTwo > 30)
            {
                return answer;
            }
            else
            {
                if((numberOne >= 20 && numberOne <= 30) || (numberTwo >= 20 && numberTwo <= 30))
                {
                    if((numberOne >= 20 && numberOne <=30) && (numberTwo < 20 && numberTwo > 30))
                    {
                        answer = numberOne;
                    }
                    else if((numberOne < 20 && numberOne > 30) && (numberTwo >= 20 && numberTwo <= 30))
                    {
                        answer = numberTwo;
                    }
                    else
                    {
                        int firstSubtract = numberOne - numberTwo;
                        int secondSubtract = numberTwo - numberOne;
                        if (firstSubtract > secondSubtract)
                        {
                            answer = numberOne;
                        }
                        else
                        {
                            answer = numberTwo;
                        }
                    }
                }
            }
            return answer;
        }
    }
}
