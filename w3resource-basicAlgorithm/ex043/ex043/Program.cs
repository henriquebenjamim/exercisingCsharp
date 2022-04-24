using System;

namespace ex043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //43.Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both. Go to the editor

            //Sample Input:
            //3
            //7
            //21
            //Expected Output:
            //True
            //True
            //False

            Console.WriteLine(multipleThreeSeven(3));
            Console.WriteLine(multipleThreeSeven(7));
            Console.WriteLine(multipleThreeSeven(21));
        }

        public static bool multipleThreeSeven(int number)
        {
            bool answer = false;
            if(number % 3 == 0)
            {
                if(number % 7 != 0)
                {
                    answer = true;
                }
            }
            else if(number % 7 == 0)
            {
                if(number % 3 != 0)
                {
                    answer = true;
                }
            }

            return answer;
        }
    }
}
