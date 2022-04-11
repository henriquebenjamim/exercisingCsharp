using System;

namespace ex060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //60.Write a C# program to calculate the sum of all the integers of a rectangular matrix except those integers which are located below an intger of value 0.
            //Sample Example:
            //matrix =
            //[[0, 2, 3, 2],
            //[0, 6, 0, 1],
            //[4, 0, 3, 0]]
            //Eligible integers which will be participated to calculate the sum -
            //matrix =
            //[[X, 2, 3, 2],
            //[X, 6, X, 1],
            //[X, X, X, X]]
            //Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14

            int[][] matrixNumbers = { new int[]{ 0, 2, 3, 2 }, new int[]{ 0, 6, 0, 1 }, new int[]{ 4, 0, 3, 0 } };
            Console.WriteLine();
            int sum = 0;

            for(int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if(i == 0 || i == 1)
                    {
                        if(j == 1 || j == 2 || j == 3)
                        {
                            if(i == 1 && j == 2)
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(matrixNumbers[i][j]);
                                sum += matrixNumbers[i][j];
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
