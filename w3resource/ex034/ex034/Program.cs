using System;

namespace ex034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //34.Write a C# program to check if a string starts with a specified word.
            //Note: Suppose the sentence starts with "Hello"
            //Sample Data: string1 = "Hello how are you?"
            //Result: Hello.
            //Sample Output:
            //Input a string : Hello how are you?
            //True

            Console.Write("Input a string: ");
            string word = Console.ReadLine();
            string[] wordsArr = word.Split(' ');
            Console.WriteLine(wordsArr[0] == "Hello");
            
        }
    }
}
