using System;

namespace ex090
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //90.Write a C# Sharp program to count number of ones and zeros in the binary representation of a given integer.
            //Sample Output:
            //Original number: 12
            //Number of ones and zeros in the binary representation of the said number:
            //Number of ones: 2
            //Number of zeros: 2
            //Original number: 1234
            //Number of ones and zeros in the binary representation of the said number:
            //Number of ones: 5
            //Number of zeros: 6

            Console.WriteLine(countingNumbersBinary(12));
            Console.WriteLine(countingNumbersBinary(1234));
        }

        public static string countingNumbersBinary(int number)
        {
            string binary = Convert.ToString(number, 2);
            // this base can be 2, 4, 8, 16

            int countingNumberOne = 0;
            int countingNumberZero = 0;

            foreach(char c in binary)
            {
                if(c == '1' || c == '0')
                {
                    if(c == '1')
                    {
                        countingNumberOne += 1;
                    }
                    else
                    {
                        countingNumberZero += 1;
                    }
                }
            }

            return $"Original number: {number}\n" +
                $"Number of ones and zeros in the binary representation of the said number:\n" +
                $"Number of ones: {countingNumberOne}\n" +
                $"Number of zeros: {countingNumberZero}\n";
        }
    }
}
