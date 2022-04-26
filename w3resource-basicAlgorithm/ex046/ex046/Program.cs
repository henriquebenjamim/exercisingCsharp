using System;

namespace ex046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //46.Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". If the string starts with "F" return "Fizz"
            //and return "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz".
            //In other cases return the original string.

            //Sample Input:
            //"FizzBuzz"
            //"Fizz"
            //"Buzz"
            //"Founder"
            //Expected Output:
            //Fizz
            //Fizz
            //Buzz
            //Fizz

            Console.WriteLine(fizzBuzz("FizzBuzz"));
            Console.WriteLine(fizzBuzz("Fizz"));
            Console.WriteLine(fizzBuzz("Buzz"));
            Console.WriteLine(fizzBuzz("Founder"));
            Console.WriteLine(fizzBuzz("FizzBubbleB"));
        }

        public static string fizzBuzz(string str)
        {
            string answerStr = string.Empty;
            bool firstCondition = str[0] == 'F';
            bool secondCondition = str[str.Length - 1] == 'B';
            if(firstCondition && secondCondition)
            {
                answerStr += "FizzBuzz";
            }
            else
            {
                if(firstCondition)
                {
                    answerStr += "Fizz";
                }
                else if(secondCondition)
                {
                    answerStr += "Buzz";
                }
                else
                {
                    answerStr += str;
                }
            }

            return answerStr;
        }

    }
}
