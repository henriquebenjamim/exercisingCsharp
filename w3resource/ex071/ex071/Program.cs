using System;

namespace ex071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //71.Write a C# Sharp program to check if a given string contains two similar consecutive letters. Go to the editor
            //Sample Output:
            //Original string: PHP
            //Test for consecutive similar letters! False
            //Original string: PHHP
            //Test for consecutive similar letters! True
            //Original string: PHPP
            //Test for consecutive similar letters! True
            //Original string: PPHP
            //Test for consecutive similar letters! True

            Console.WriteLine("Original string: ");
            string word = Console.ReadLine();

            Console.WriteLine(twoSimilars(word));
        }

        public static string twoSimilars(string word)
        {
            string answer = "";
            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (i < word.Length - 1)
                {
                    if (word[i] == word[i + 1])
                    {
                        answer = "True";
                        break;
                    }
                }
                if (i == word.Length - 1 && answer != "True")
                {
                    answer = "False";
                }
            }
            return answer;
        }
    }
}
