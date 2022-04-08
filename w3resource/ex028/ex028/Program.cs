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
            
            
            for (int i = ori.Length -1; i >= 0; i--)
            {
                Console.WriteLine(ori[i]);

            }
            //Console.WriteLine(reverseString("Henrique benjamim de brito rocha"));
        }

        // i will create a recursive method on this
        //public static string reverseString(string original)
        //{
        //    string[] ori = original.Split(' ');

        //    return ori.Length > 1 ? Console.WriteLine(ori[ori.Length -1)] : original;
        //}
    }
}
