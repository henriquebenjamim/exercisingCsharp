using System;

namespace ex059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //59.Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array.
            int[] arrOne = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arrTwo = { 3, 1, 2, 6 };


            Console.WriteLine(increasingSequence(arrOne));
            Console.WriteLine(increasingSequence(new int[] { 3, 1, 2, 6 }));
            Console.WriteLine(increasingSequence(new int[] { 1, 3, 5, 6, 9 }));
            Console.WriteLine(increasingSequence(new int[] { 0, 10 }));
            Console.WriteLine(increasingSequence(new int[] { 1, 3, 1, 3 }));
            //foreach(int value in arrOne)
            //{   
            //    if(value == )
            //    if(value > lastValue)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(false);
            //        break;
            //    }
            //}

        }

        public static bool increasingSequence(int [] arr)
        {
            int notIncreasing = 0;
            for(int i = 0; i < arr.Length - 1; i++)
            {   
                
                if(arr[i] >= arr[i+1])
                {
                    notIncreasing += 1;
                }
                if(i + 2 < arr.Length && arr[i] >= arr[i + 2])
                {
                    notIncreasing += 1;
                }
            }

            return notIncreasing <= 2;
        }


    }
}
