using System;

namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged. Go to the editor

            //Sample Input:
            //"if else"
            //"else"
            //Expected Output:
            //if else
            //if else

            Console.WriteLine(changingString("if else"));
            Console.WriteLine(changingString("else"));
            Console.WriteLine(changingString("Hello"));
        }

        public static string changingString(string str)
        {
            if(str[0] == 'i' && str[1] == 'f')
            {
                return str;
            }
            return $"if {str}";
        }
    }
}
