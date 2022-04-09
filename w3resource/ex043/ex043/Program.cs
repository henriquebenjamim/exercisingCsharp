using System;

namespace ex043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //43.Write a C# program to check if a given string starts with "w" and immediately followed by two "ww".
            //Test Data:
            //Input a string : www
            //Sample Output
            //False

            Console.Write("Input a string: ");
            string site = Console.ReadLine();
            Console.WriteLine(siteCondition(site));
        }

        public static bool siteCondition(string str)
        {
            if(str.Length >= 3 && str.Substring(0, 3) == "www")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
