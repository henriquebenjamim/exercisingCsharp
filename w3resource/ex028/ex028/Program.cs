using System;

namespace ex028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //28.Write a C# program to reverse the words of a sentence.
            //Sample Output:
            //Original String: Display the pattern like pyramid using the alphabet.
            //Reverse String: alphabet.the using pyramid like pattern the Display

            Console.WriteLine("Original String:");
            string originalString = Console.ReadLine();
            string[] ori = originalString.Split(' ');
            string reverseString;
            for (int i = ori.Length -1; i >= 0; i--)
            {
                Console.WriteLine(ori[i]);

            }
        }

        public static string reverseString(string original)
        {
            return "ok";
        }
    }
}
