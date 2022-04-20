using System;

namespace ex029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //29.Write a C# Sharp program to create a new string made of every other character starting with the first from a given string. Go to the editor

            //Sample Input:
            //"Python"
            //"PHP"
            //"JS"
            //Expected Output:
            //Pto
            //PP
            //J

            Console.WriteLine(removingChars(("Python")));
            Console.WriteLine(removingChars(("PHP")));
            Console.WriteLine(removingChars("JS"));
            
        }

        public static string removingChars(string str)
        {
            string word = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (word[i] % 2 == 0)
                {
                    str += word[i];
                }
            }

            return word;
        }

    }
}
