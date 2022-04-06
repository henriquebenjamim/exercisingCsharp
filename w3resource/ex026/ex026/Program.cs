using System;

namespace ex026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Numeros primos são números naturais que podem ser divididos por apenas 2 divisores(o número 1 e ele mesmo)
            // Dica: o unico primo que é par é o número 2 (dois).
            //26.Write a C# program to compute the sum of the first 500 prime numbers.
            //Sample Output:
            //Sum of the first 500 prime numbers:
            //824693

            int[] arrayDivisorNumbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            int countingPrimeNumbers = 17;
            int countDivisors = 0;
            int countLoop = 4;
            int number = 10;
            while (countLoop <= 500)
            {
                if (number % 2 != 0)
                {
                    for(int i = 0; i < 19; i++)
                    {   
                        if(i == 18)
                        {
                            if(number % number == 0)
                            {
                                countDivisors += 1;
                                break;
                            }
                        }
                        else
                        {
                            if (number % arrayDivisorNumbers[i] == 0)
                            {
                                countDivisors += 1;
                            }
                        }
                        
                    }
                    if(countDivisors == 2)
                    {
                        Console.WriteLine($"{countLoop} => {number}");
                        countingPrimeNumbers += number;
                        countLoop += 1;
                    }
                }
                
                number += 1;
                countDivisors = 0;
            }
            Console.WriteLine(countingPrimeNumbers);
        }
    }
}
