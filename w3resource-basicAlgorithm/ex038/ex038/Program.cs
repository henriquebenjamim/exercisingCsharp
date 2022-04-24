using System;

namespace ex038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //38.Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. Also count the situation where the second 5 is actually a 6. Go to the editor

            //Sample Input:
            //{ 5, 5, 2 }
            //{ 5, 5, 2, 5, 5 }
            //{ 5, 6, 2, 9}
            //Expected Output:
            //1
            //2
            //1
            Console.WriteLine(countingFive(new[] { 5, 5, 2}));
            Console.WriteLine(countingFive(new[] {5, 5, 2, 5, 5}));
            Console.WriteLine(countingFive(new[] {5, 6, 2, 9}));
        }

        public static int countingFive(int[] numbersArr)
        {
            int counting = 0;

            for(int i = 0; i < numbersArr.Length -1; i++)
            {
                if(numbersArr[i] == 5)
                {
                    if(numbersArr[i + 1] == 5 || numbersArr[i + 1] == 6)
                    {
                        counting += 1;
                    }
                }
            }

            return counting;
        }
    }
}
