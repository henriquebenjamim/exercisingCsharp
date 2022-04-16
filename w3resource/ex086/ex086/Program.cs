using System;

namespace ex086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //86.Write a C# Sharp program to get the number of letters and digits in a given string.
            //Sample Output:
            //Original string::Python 3.0
            //Number of letters: 6 Number of digits: 2
            //Original string::dsfkaso230samdm2423sa
            //Number of letters: 14 Number of digits: 7


            //097 - 122 a to z
            //065 - 090 A to Z
            //048 - 057 0 to 9

            Console.WriteLine("Give me a string: ");
            string str = Console.ReadLine();

            Console.WriteLine(amountLettersNumbers(str));
        }

        public static string amountLettersNumbers(string str)
        {
            int numbersAmount = 0;
            int lettersAmount = 0;


            foreach (byte c in str)
            {
                if (c >= 048 && c <= 122)
                {
                    if (c >= 48 && c <= 57)
                    {
                        numbersAmount += 1;
                    }
                    else
                    {
                        if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
                        {
                            lettersAmount += 1;
                        }
                    }
                }
            }

            return $"Number of letters: {lettersAmount} Number of digits: {numbersAmount}";
        }
    }
}
