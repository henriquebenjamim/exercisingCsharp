using System.Threading;

//Write a C# Sharp program to swap two numbers.
Console.Write("Input the First Number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Input the Second Number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Swapping...");
Thread.Sleep(2000);
int substitute = firstNumber;
firstNumber = secondNumber;
secondNumber = substitute;
Console.WriteLine("After Swapping :");
Console.WriteLine($"First Number : {firstNumber}");
Console.WriteLine($"Second Number : {secondNumber}");
