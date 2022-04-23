using System;

namespace ex031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //31.Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. Do not count the end substring.

            //Sample Input:
            //"abcdsab"
            //"abcdabab"
            //"abcabdabab"
            //"abcabd"
            //Expected Output:
            //1
            //2
            //3
            //0

            Console.WriteLine(countingSub("abcdsab"));
            Console.WriteLine(countingSub("abcdsabab"));
            Console.WriteLine(countingSub("abcabdabab"));
            Console.WriteLine(countingSub("abcabd"));
        }

        public static int countingSub(string s)
        {
            int counting = 0;

            for(int i = 0; i < s.Length -2; i++)
            {
                if(s.Substring(i, 2).Equals(s.Substring(s.Length - 2)))
                {
                    counting += 1;
                }
            }

            return counting;
        }
    }
}
