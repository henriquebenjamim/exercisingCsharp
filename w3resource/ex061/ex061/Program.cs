using System;
using System.Linq;

namespace ex061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //61.Write a C# program to sort the integers in ascending order without moving the number -5.
            int[] arr = sortingNumbers(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });

            foreach(var value in arr)
            {
                Console.WriteLine(value.ToString());
            }
        }

        public static int[] sortingNumbers(int[] arr)
        {
            int[] num = arr.Where(x => x != -5).OrderBy(x => x).ToArray();
            int counting = 0;

            return arr.Select(x => x >= 0 ? num[counting++] : -5).ToArray();
        }

        
    }
}
