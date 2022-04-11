using System;

namespace ex058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //58.Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range.
            //Sample Example[1, 3, 4, 7, 9], between 1 - 9-> 2, 5, 6, 8 are not present in the list. So output will be 4.
            int[] arr1 = { 1, 3, 4, 7, 9 };
            int count = 1;
            int neededNumbers = 9;
            while(count <= 9)
            {
                foreach(int value in arr1)
                {
                    if(count == value)
                    {
                        neededNumbers -= 1;
                        break;
                    }
                }
                count += 1;
            }
            Console.WriteLine($"{neededNumbers} are needed to complete the range.");
        }
    }
}
