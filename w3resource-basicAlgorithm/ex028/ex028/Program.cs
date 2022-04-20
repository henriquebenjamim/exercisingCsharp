using System;

namespace ex028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //28.Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a". Go to the editor

            //Sample Input:
            //"caabb"
            //"babaaba"
            //"aaaaa"

            //Expected Output:
            //True
            //False
            //True

            Console.WriteLine(checkConsecutiveChars("caabb"));
            Console.WriteLine(checkConsecutiveChars("babaaba"));
            Console.WriteLine(checkConsecutiveChars("aaaaa"));

        }

        public static bool checkConsecutiveChars(string str)
        {
            bool answer = false;
            int searchingIndx = str.IndexOf('a');
            if(searchingIndx + 1 <= str.Length)
            {
                if (str[searchingIndx] == str[searchingIndx + 1])
                {
                    answer = true;
                }
            }

            return answer;
        }
    }
}
