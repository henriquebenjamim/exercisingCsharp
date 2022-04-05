using System;

namespace ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14.Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. Go to the editor
            //Test Data:
            //Enter the amount of celsius: 30
            //Expected Output:
            //Kelvin = 303
            //Fahrenheit = 86

            Console.Write("Enter the amount of celsius: ");
            int celsius = int.Parse(Console.ReadLine());

            // 0 °C + 273,15 = 273,15 K
            Console.WriteLine($"Kelvin: {celsius + 273}");
            
            //(0 °C × 9/5) + 32 = 32 °F
            Console.WriteLine($"Fahrenheit: {(celsius* 9/5) + 32}");
        }
    }
}
