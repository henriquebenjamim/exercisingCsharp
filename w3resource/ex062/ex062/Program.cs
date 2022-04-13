using System;
using System.Linq;
using System.Collections;

namespace ex062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //62.Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string and also remove the parentheses within the given string.
            string name = "oh(my)god)";
            string henrique = "Henrique";

            Console.WriteLine(removingParentheses("p(rq)st"));
            Console.WriteLine(removingParentheses("(p(rq)st)"));
            Console.WriteLine(name);
            Console.WriteLine(henrique);
            

            
        }

        public static string removingParentheses(string str)
        {
            int findingLeft = str.LastIndexOf("(");

            if(findingLeft == -1)
            {
                return str;
            }
            else
            {
                int findingRight = str.IndexOf(")", findingLeft);
                return removingParentheses($"{str.Substring(0, findingLeft)}{new string(str.Substring(findingLeft + 1, findingRight - findingLeft - 1).Reverse().ToArray())}{str.Substring(findingRight + 1)}");
            }

        }
    }
}
