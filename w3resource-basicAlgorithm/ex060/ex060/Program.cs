using System;

namespace ex060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //60.Write a C# Sharp program to create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1.

            //Sample Input:
            //"Hi", "Hello"
            //"whats", "app"
            //Expected Output:
            //HiHelloHelloHi
            //whatsappappwhats

            Console.WriteLine(oneTwoTwoOne("Hi", "Hello"));
            Console.WriteLine(oneTwoTwoOne("whats", "app"));
            Console.WriteLine(oneTwoTwoOne("one","two"));
        }

        public static string oneTwoTwoOne(string str1, string str2)
        {
            return $"{str1}{str2}{str2}{str1}";
        }
    }
}
