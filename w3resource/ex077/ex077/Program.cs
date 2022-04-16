using System;

namespace ex077
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //77.Write a C# Sharp program to check whether a given word is plural or not.
            //Sample Output:
            //Is 'Exercise' is plural ? False
            //Is 'Exercises' is plural ? True
            //Is 'Books' is plural ? True
            //Is 'Book' is plural ? False

            Console.Write("Give me a word: ");
            string word = Console.ReadLine();

            Console.WriteLine(plural(word));
        }

        public static bool plural(string str)
        {
            return str[str.Length - 1] != 's' ? false : true;
        }
    }
}
