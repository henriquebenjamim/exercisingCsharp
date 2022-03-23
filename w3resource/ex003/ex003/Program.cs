using System.Globalization;

// Write a C# Sharp program to print the result of dividing two numbers.

double numberOne = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double numberTwo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


if (numberTwo != 0)
{
    Console.WriteLine($"{numberOne} / {numberTwo} = {(numberOne / numberTwo).ToString("F2", CultureInfo.InvariantCulture)}");
}
else
{
    Console.WriteLine("invalid number, we can't divide per zero");
}

