using System;

namespace ex067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //67.Write a C# Sharp program to create a coded string from a given string, using specified formula. Go to the editor
            //Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
            //Sample Output:
            //969
            //J8V81CRI90

            Console.WriteLine("Give me a string: ");
            string word = Console.ReadLine();

            foreach(char value in word)
            {
                switch (value.ToString())
                {
                    case "P":
                        Console.Write("9");
                        break;
                    case "T":
                        Console.Write("0");
                        break;
                    case "S":
                        Console.Write("1");
                        break;
                    case "H":
                        Console.Write("6");
                        break;
                    case "A":
                        Console.Write("8");
                        break;
                    default:
                        Console.Write(value);
                        break;
                }
            }
        }
    }
}
