using System;

namespace ex053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //53.Write a C# Sharp program to check two given integers, each in the range 10..99. Return true if a digit appears in both numbers, such as the 3 in 13 and 33.

            //Sample Input:
            //11, 21
            //11, 20
            //10, 10
            //Expected Output:
            //True
            //False
            //True

            Console.WriteLine(checkRangeNumbers(11, 21));
            Console.WriteLine(checkRangeNumbers(11, 20));
            Console.WriteLine(checkRangeNumbers(10, 10));
        }
        
        public static bool checkRangeNumbers(int numberOne, int numberTwo)
        {
            string firstOne = numberOne.ToString();
            string secondOne = numberTwo.ToString();

            int counting = 0;
            for (int i = 0; i < 2; i++)
            {
                if(i != 1)
                {
                    if (firstOne[i] == secondOne[i] || firstOne[i] == secondOne[i + 1])
                    {
                        counting += 1;
                    }
                }
            }

            return (numberOne >= 10 && numberOne <= 99) && (numberTwo >= 10 && numberTwo <= 99) && counting >= 1 ? true : false;
        }
    }
}
