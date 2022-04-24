using System;

namespace ex036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //36.Write a C# Sharp program to create a new string from a give string where a specified character have been removed except starting and ending position of the given string.

            //Sample Input:
            //"xxHxix", "x"
            //"abxdddca", "a"
            //"xabjbhtrb", "b"
            //Expected Output:
            //xHix
            //abxdddca
            //xajhtrb

            Console.WriteLine(removingSpecificCharac("xxHxix", 'x'));
            Console.WriteLine(removingSpecificCharac("abxdddca", 'a'));
            Console.WriteLine(removingSpecificCharac("xabjbhtrb", 'b'));
        }

        public static string removingSpecificCharac(string str, char milionaire)
        {
            for(int i = 1; i < str.Length - 2; i++)
            {
                if(str[i] == milionaire)
                {
                    str = str.Remove(i, 1);
                }
            }
            return str;
        }
    }


}
